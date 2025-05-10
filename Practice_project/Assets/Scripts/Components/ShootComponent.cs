using System;
using AtomicPlayground.Proxy;
using Sirenix.OdinInspector;
using UnityEngine;
using Object = UnityEngine.Object;

namespace AtomicPlayground.Components
{
    [Serializable]
    public class ShootComponent
    {
        [SerializeField] 
        private float reloadTime = 2f;

        [SerializeField]
        private bool isReloading;

        [SerializeField]
        private Bullet bulletPrefab;

        [SerializeField]
        private Transform firePoint;

        [ShowInInspector, ReadOnly]
        private float _reloadTimer;
        
        public CompositeCondition CanFire = new();

        public void OnUpdate(float deltaTime)
        {
            if (!isReloading)
                return;
            _reloadTimer -= deltaTime;
            if (_reloadTimer <= 0)
                isReloading = false;
        }

        public void Shoot()
        {
            if (!CanFire.IsTrue())
            {
                return;
            }
            
            if (isReloading)
                return;

            var bullet = Object.Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            bullet.SetDirection(firePoint.forward);
            
            _reloadTimer = reloadTime;
            isReloading = true;
        }
    }
}