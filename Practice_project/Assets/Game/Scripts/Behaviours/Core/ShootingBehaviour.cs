using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game.Behaviours
{
    public class ShootingBehaviour : IEntityInit, IEntityUpdate, IEntityDispose
    {
        private SceneEntity _bulletPrefab;
        private Transform _firePointTransform;
        private IEvent _shootAction;


        public void Init(IEntity entity)
        {
            _bulletPrefab = entity.GetBulletPrefab();
            _firePointTransform = entity.GetFirePointTransform();

            _shootAction = entity.GetShootAction();
            _shootAction.Subscribe(HandleShootAction);
        }

        public void OnUpdate(IEntity entity, float deltaTime)
        {
            
        }

        public void Dispose(IEntity entity)
        {
            _shootAction.Unsubscribe(HandleShootAction);
        }

        private void HandleShootAction()
        {
            var bullet = Object.Instantiate(_bulletPrefab,
                _firePointTransform.position,
                _firePointTransform.rotation);
            bullet.GetBulletDirection().Value = _firePointTransform.forward;
        }
    }
}