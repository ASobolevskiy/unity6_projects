using Atomic.Entities;
using UnityEngine;

namespace Game.Core.Installers
{
    public sealed class BulletInstaller : SceneEntityInstallerBase
    {
        [SerializeField]
        private BulletMovementInstaller _bulletMovementInstaller;

        [SerializeField]
        private BulletHitInstaller _bulletHitInstaller;
        
        public override void Install(IEntity entity)
        {
            entity.AddBulletTag();
            _bulletMovementInstaller.Install(entity);
            _bulletHitInstaller.Install(entity);
        }
    }
}