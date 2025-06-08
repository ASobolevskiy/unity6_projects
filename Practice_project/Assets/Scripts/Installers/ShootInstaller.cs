using System;
using Atomic.Elements;
using Atomic.Entities;
using AtomicPlayground.Mechanics;
using UnityEngine;
using UnityEngine.Serialization;

namespace AtomicPlayground
{
    [Serializable]
    public class ShootInstaller : IEntityInstaller
    {
        [SerializeField]
        private float _reloadTime = 2f;

        [SerializeField]
        private Transform _firePoint;

        [SerializeField]
        private Bullet _bulletPrefab;

        [SerializeField]
        private int _maxAmmo = 30;
        
        public void Install(IEntity entity)
        {
            entity.SetReloadTime(new ReactiveVariable<float>(_reloadTime));
            entity.SetIsReloading(new ReactiveVariable<bool>());
            entity.SetFirePointTransform(_firePoint);
            entity.SetBulletPrefab(_bulletPrefab);
            entity.SetShootAction(new BaseEvent());
            entity.SetShootRequest(new BaseEvent());
            entity.SetShootEvent(new BaseEvent());
            entity.SetAmmoMax(_maxAmmo);

            entity.AddBehaviour(new ShootBehaviour());
        }
    }
}