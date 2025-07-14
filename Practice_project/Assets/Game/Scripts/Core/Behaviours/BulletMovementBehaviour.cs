using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;
using Game.Context;
using Game.Utils;
using UnityEngine;

namespace Game.Core.Behaviours
{
    public sealed class BulletMovementBehaviour : IEntityInit, IEntityUpdate
    {
        private Transform _root;
        private ReactiveVariable<Vector3> _movementDirection;
        private ReactiveVariable<float> _bulletSpeed;
        private IEntity _entity;
        
        public void Init(IEntity entity)
        {
            _root = entity.GetBulletTransform();
            _movementDirection = entity.GetBulletDirection();
            _bulletSpeed = entity.GetBulletSpeed();
            _entity = entity;
        }

        public void OnUpdate(IEntity entity, float deltaTime)
        {
            var boundsHelper = new BoundsHelper();
            var newPosition = _root.position + _movementDirection.Value * (_bulletSpeed.Value * deltaTime);
            if (boundsHelper.IsInBounds(newPosition))
            {
                _root.position = newPosition;
            }
            else
            {
                GameContext.Instance.GetEntityDestroyRequest().Invoke(_entity);
            }
        }
    }
}