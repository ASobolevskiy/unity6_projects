using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game.Behaviours
{
    public sealed class MovementBehaviour : IEntityInit, IEntityUpdate
    {
        private Transform _root;
        private ReactiveVariable<Vector3> _movementDirection;
        private ReactiveVariable<float> _movementSpeed;
        private ReactiveVariable<bool> _isMoving;

        public void Init(IEntity entity)
        {
            _root = entity.GetRootTransform();
            _movementDirection = entity.GetMovementDirection();
            _movementSpeed = entity.GetMovementSpeed();
            _isMoving = entity.GetIsMoving();
        }

        public void OnUpdate(IEntity entity, float deltaTime)
        {
            _isMoving.Value = _movementDirection.Value.sqrMagnitude > 0;
            _root.position += _movementDirection.Value * (_movementSpeed.Value * deltaTime);
        }
    }
}