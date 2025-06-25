using Atomic.Entities;
using UnityEngine;

namespace Game.Core.Installers
{
    public sealed class PlayerInstaller : SceneEntityInstallerBase
    {
        [SerializeField]
        private MovementInstaller _movementInstaller;

        [SerializeField]
        private ShootingInstaller _shootingInstaller;

        [SerializeField]
        private HealthInstaller _healthInstaller;
        public override void Install(IEntity entity)
        {
            _movementInstaller.Install(entity);
            _shootingInstaller.Install(entity);
            _healthInstaller.Install(entity);
        }
    }
}

