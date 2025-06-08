using Atomic.Entities;
using Game.Behaviours;
using UnityEngine;

namespace Game.Installers
{
    public class MovementInstaller : SceneEntityInstallerBase
    {
        [SerializeField]
        private Transform _rootTransform;

        [SerializeField]
        private float _movementSpeed;
        
        [SerializeField]
        private Vector3 _movementDirection = Vector3.zero;
        public override void Install(IEntity entity)
        {
            entity.SetRootTransform(_rootTransform);
            entity.SetMovementSpeed(_movementSpeed);
            entity.SetMovementDirection(_movementDirection);

            entity.AddBehaviour(new MovementBehaviour());
        }
    }
}

