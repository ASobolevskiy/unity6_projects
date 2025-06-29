using System;
using Atomic.Elements;
using Atomic.Entities;
using Game.Core.Behaviours;
using UnityEngine;

namespace Game.Core.Installers
{
    [Serializable]
    public sealed class MovementInstaller : IEntityInstaller
    {
        [SerializeField]
        private Transform _rootTransform;

        [SerializeField]
        private float _movementSpeed;
        
        [SerializeField]
        private Vector3 _movementDirection = Vector3.zero;
        public void Install(IEntity entity)
        {
            entity.SetRootTransform(_rootTransform);
            entity.SetMovementSpeed(_movementSpeed);
            entity.SetMovementDirection(_movementDirection);
            entity.SetIsMoving(new ReactiveVariable<bool>());
            entity.SetCanMove(new AndExpression());

            entity.AddBehaviour(new MovementBehaviour());
        }
    }
}

