using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game.Behaviours
{
    public class MovementBehaviour : IEntityInit, IEntityUpdate
    {
        private Transform _root;
        private ReactiveVariable<Vector3> _movementDirection;
        private ReactiveVariable<float> _movementSpeed;

        public void Init(IEntity entity)
        {
            _root = entity.GetRootTransform();
            _movementDirection = entity.GetMovementDirection();
            _movementSpeed = entity.GetMovementSpeed();
        }

        public void OnUpdate(IEntity entity, float deltaTime)
        {
            _root.position += _movementDirection.Value * (_movementSpeed.Value * deltaTime);
        }
    }
}