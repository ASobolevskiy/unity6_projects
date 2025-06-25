using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game.Core.Behaviours
{
    public sealed class BulletMovementBehaviour : IEntityInit, IEntityUpdate
    {
        private Transform _root;
        private ReactiveVariable<Vector3> _movementDirection;
        private ReactiveVariable<float> _bulletSpeed;
        public void Init(IEntity entity)
        {
            _root = entity.GetBulletTransform();
            _movementDirection = entity.GetBulletDirection();
            _bulletSpeed = entity.GetBulletSpeed();
        }

        public void OnUpdate(IEntity entity, float deltaTime)
        {
            _root.position += _movementDirection.Value * (_bulletSpeed.Value * deltaTime);
        }
    }
}