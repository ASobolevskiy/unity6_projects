using Atomic.Elements;
using Atomic.Entities;
using AtomicPlayground.Components;
using UnityEngine;

namespace AtomicPlayground.Mechanics
{
    public class ShootBehaviour : IEntityInit, IEntityUpdate, IEntityDispose
    {
        private ReactiveVariable<float> _reloadTime;
        private ReactiveVariable<bool> _isReloading;
        private Bullet _bulletPrefab;
        
        private float _reloadTimer;
        private Transform _firePointTransform;
        private BaseEvent _shootAction;

        public void Init(IEntity entity)
        {
            _reloadTime = entity.GetReloadTime();
            _isReloading = entity.GetIsReloading();
            _bulletPrefab = entity.GetBulletPrefab();
            _firePointTransform = entity.GetFirePointTransform();
            
            _shootAction = entity.GetShootAction();
            _shootAction.Subscribe(HandleOnShoot);
        }

        public void OnUpdate(IEntity entity, float deltaTime)
        {
            if (!_isReloading.Value)
                return;
            _reloadTimer -= deltaTime;
            if (_reloadTimer <= 0)
                _isReloading.Value = false;
        }

        private void HandleOnShoot()
        {
            if (_isReloading.Value)
                return;
            var bullet = Object.Instantiate(_bulletPrefab, _firePointTransform.position, _firePointTransform.rotation);
            bullet.SetDirection(_firePointTransform.forward);
            
            _reloadTimer = _reloadTime.Value;
            _isReloading.Value = true;
        }

        public void Dispose(IEntity entity)
        {
            _shootAction.Unsubscribe(HandleOnShoot);
        }
    }
}