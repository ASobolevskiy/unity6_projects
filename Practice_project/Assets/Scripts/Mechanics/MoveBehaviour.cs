using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Mechanics
{
    public class MoveBehaviour : IEntityInit, IEntityUpdate
    {
        private Transform _root;
        private ReactiveVariable<Vector3> _moveDirection;
        private ReactiveVariable<float> _moveSpeed;
        private ReactiveVariable<bool> _isMoving;
        public void Init(IEntity entity)
        {
            _root = entity.GetRootTransform();
            _moveDirection = entity.GetMoveDirection();
            _moveSpeed = entity.GetMoveSpeed();
            _isMoving = entity.GetIsMoving();
        }
        public void OnUpdate(IEntity entity, float deltaTime)
        {
            _isMoving.Value = _moveDirection.Value.sqrMagnitude > 0;
            _root.position += _moveDirection.Value * (_moveSpeed.Value * deltaTime);
        }
    }
}