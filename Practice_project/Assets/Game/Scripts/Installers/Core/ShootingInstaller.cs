using Atomic.Elements;
using Atomic.Entities;
using Game.Behaviours;
using UnityEngine;

namespace Game.Installers
{
    public sealed class ShootingInstaller : SceneEntityInstallerBase
    {
        [SerializeField]
        private Transform _firePointTransform;

        [SerializeField]
        private float _shootDelayTime;

        [SerializeField]
        private int _maxAmmo;

        [SerializeField]
        private float _ammoReplenishTime;

        [SerializeField]
        private SceneEntity _bullet;
        public override void Install(IEntity entity)
        {
            entity.SetFirePointTransform(_firePointTransform);
            entity.SetShootDelayTime(_shootDelayTime);
            entity.SetBulletPrefab(_bullet);
            entity.SetIsShotDelaying(new ReactiveVariable<bool>());
            entity.SetMaximumAmmo(_maxAmmo);
            entity.SetAmmoReplenishTime(_ammoReplenishTime);
            entity.SetIsAmmoReplenishing(new ReactiveVariable<bool>());
            entity.SetCurrentAmmo(_maxAmmo);
            entity.SetShootRequest(new BaseEvent());
            entity.SetShootAction(new BaseEvent());
            entity.SetShootEvent(new BaseEvent());

            entity.AddBehaviour(new ShootingBehaviour());
        }
    }
}