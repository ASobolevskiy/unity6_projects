using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;
using Game.Context;
using Game.Utils;
using Unity.Mathematics.Geometry;
using UnityEngine;

namespace Game.Core.Behaviours
{
    public sealed class MovementBehaviour : IEntityInit, IEntityUpdate
    {
        private Transform _root;
        private ReactiveVariable<Vector3> _movementDirection;
        private ReactiveVariable<float> _movementSpeed;
        private ReactiveVariable<bool> _isMoving;
        private AndExpression _canMove;

        public void Init(IEntity entity)
        {
            _root = entity.GetRootTransform();
            _movementDirection = entity.GetMovementDirection();
            _movementSpeed = entity.GetMovementSpeed();
            _isMoving = entity.GetIsMoving();
            _canMove = entity.GetCanMove();
        }

        public void OnUpdate(IEntity entity, float deltaTime)
        {
            if (!_canMove.Invoke())
            {
                _isMoving.Value = false;
                return;
            }

            _isMoving.Value = _movementDirection.Value.sqrMagnitude > 0;

            var boundsHelper = new BoundsHelper();
            var newPosition = _root.position + _movementDirection.Value.normalized * (_movementSpeed.Value * deltaTime);
            _root.position = boundsHelper.EnsureStayInBounds(newPosition);
        }
    }
}