using Atomic.Entities;
using Game.Core.Behaviours;
using UnityEngine;

namespace Game.Core.Installers
{
    public class EnemyInstaller : SceneEntityInstallerBase
    {
        [SerializeField]
        private Transform _target;

        [SerializeField]
        private RotationInstaller _rotationInstaller;

        [SerializeField]
        private MovementInstaller _movementInstaller;

        [SerializeField]
        private HealthInstaller _healthInstaller;
        public override void Install(IEntity entity)
        {
            entity.SetTarget(_target);
            
            _movementInstaller.Install(entity);
            _rotationInstaller.Install(entity);
            _healthInstaller.Install(entity);

            entity.AddBehaviour(new TargetLookUpBehaviour());
        }
    }
}