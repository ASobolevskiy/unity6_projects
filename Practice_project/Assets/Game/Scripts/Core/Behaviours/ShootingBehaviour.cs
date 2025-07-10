using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;
using Game.Context;
using Game.Utils;
using UnityEngine;

namespace Game.Core.Behaviours
{
    public sealed class ShootingBehaviour : IEntityInit, IEntityUpdate, IEntityDispose
    {
        private SceneEntity _bulletPrefab;
        private Transform _firePointTransform;
        private IEvent _shootAction;
        private IEvent _shootEvent;
        private IEvent _dryShotEvent;
        private ReactiveVariable<float> _shootDelayTime;
        private ReactiveVariable<bool> _isShotDelaying;
        private ReactiveVariable<int> _maximumAmmo;
        private ReactiveVariable<float> _ammoReplenishTime;
        private ReactiveVariable<bool> _isAmmoReplenishing;
        private ReactiveVariable<int> _currentAmmo;
        private AndExpression _canReplenishBullets;

        private float _delayTimer;
        private float _replenishTimer;
        
        public void Init(IEntity entity)
        {
            _bulletPrefab = entity.GetBulletPrefab();
            _firePointTransform = entity.GetFirePointTransform();
            _shootDelayTime = entity.GetShootDelayTime();
            _isShotDelaying = entity.GetIsShotDelaying();
            _maximumAmmo = entity.GetMaximumAmmo();
            _ammoReplenishTime = entity.GetAmmoReplenishTime();
            _isAmmoReplenishing = entity.GetIsAmmoReplenishing();
            _currentAmmo = entity.GetCurrentAmmo();
            _canReplenishBullets = entity.GetCanReplenishBullets();
            
            _shootAction = entity.GetShootAction();
            _shootAction.Subscribe(HandleShootAction);

            _shootEvent = entity.GetShootEvent();
            _dryShotEvent = entity.GetDryShotEvent();
        }

        public void OnUpdate(IEntity entity, float deltaTime)
        {
            HandleShotDelay(deltaTime);
            HandleAmmoReplenishing(deltaTime);
        }

        private void HandleShotDelay(float deltaTime)
        {
            if(!_isShotDelaying.Value)
            {
                return;
            }

            _delayTimer -= deltaTime;
            if (_delayTimer <= 0)
            {
                _isShotDelaying.Value = false;
            }
        }

        private void HandleAmmoReplenishing(float deltaTime)
        {
            if (!_canReplenishBullets.Invoke())
            {
                return;
            }

            if (!_isAmmoReplenishing.Value)
            {
                return;
            }

            _replenishTimer -= deltaTime;
            if (_replenishTimer > 0)
            {
                return;
            }

            _currentAmmo.Value++;
            if(_currentAmmo.Value != _maximumAmmo.Value)
            {
                _replenishTimer = _ammoReplenishTime.Value;
            }
            else
            {
                _isAmmoReplenishing.Value = false;
            }
        }

        public void Dispose(IEntity entity)
        {
            _shootAction.Unsubscribe(HandleShootAction);
        }

        private void HandleShootAction()
        {
            if (_isShotDelaying.Value)
            {
                return;
            }

            if (_currentAmmo.Value == 0)
            {
                _dryShotEvent.Invoke();
                return;
            }

            var position = _firePointTransform.position;
            var direction = _firePointTransform.forward;
            direction.y = 0;
            GameContext.Instance.GetBulletSpawRequest().Invoke(new BulletSpawnArguments(position, direction));
            // var bullet = Object.Instantiate(_bulletPrefab,
            //     _firePointTransform.position,
            //     _firePointTransform.rotation);
            
            // bullet.GetBulletDirection().Value = direction;

            _shootEvent.Invoke();
            
            _delayTimer = _shootDelayTime.Value;
            _isShotDelaying.Value = true;
            _currentAmmo.Value--;
            
            if (_currentAmmo.Value != _maximumAmmo.Value - 1)
            {
                return;
            }

            _replenishTimer = _ammoReplenishTime.Value;
            _isAmmoReplenishing.Value = true;
        }
    }
}