using Atomic.Entities;
using UnityEngine;

namespace Game.Installers
{
    public sealed class PlayerInstaller : SceneEntityInstallerBase
    {
        [SerializeField]
        private MovementInstaller _movementInstaller;
        public override void Install(IEntity entity)
        {
            _movementInstaller.Install(entity);
        }
    }
}

