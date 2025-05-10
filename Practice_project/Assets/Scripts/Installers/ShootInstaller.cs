using System;
using Atomic.Elements;
using Atomic.Entities;
using AtomicPlayground.Mechanics;
using UnityEngine;

namespace AtomicPlayground
{
    [Serializable]
    public class ShootInstaller : IEntityInstaller
    {
        [SerializeField]
        private float reloadTime = 2f;

        [SerializeField]
        private Transform firePoint;

        [SerializeField]
        private Bullet bulletPrefab;
        
        public void Install(IEntity entity)
        {
            entity.SetReloadTime(new ReactiveVariable<float>(reloadTime));
            entity.SetIsReloading(new ReactiveVariable<bool>());
            entity.SetFirePointTransform(firePoint);
            entity.SetBulletPrefab(bulletPrefab);
            entity.SetShootAction(new BaseEvent());
            entity.SetShootRequest(new BaseEvent());
            entity.SetShootEvent(new BaseEvent());

            entity.AddBehaviour(new ShootBehaviour());
        }
    }
}