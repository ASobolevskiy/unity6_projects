using Atomic.Entities;
using UnityEngine;

namespace Game.Installers
{
    public sealed class PlayerInstaller : SceneEntityInstallerBase
    {
        [SerializeField]
        private MovementInstaller _movementInstaller;

        [SerializeField]
        private ShootingInstaller _shootingInstaller;
        public override void Install(IEntity entity)
        {
            _movementInstaller.Install(entity);
            _shootingInstaller.Install(entity);
        }
    }
}

