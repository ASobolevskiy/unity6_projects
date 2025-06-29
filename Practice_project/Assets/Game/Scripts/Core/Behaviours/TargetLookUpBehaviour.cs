using Atomic.Entities;
using UnityEngine;

namespace Game.Core.Behaviours
{
    public class TargetLookUpBehaviour : IEntityInit, IEntityUpdate
    {
        private Transform _target;
        private Transform _root;
        
        public void Init(IEntity entity)
        {
            _target = entity.GetTarget();
            _root = entity.GetRootTransform();
        }

        public void OnUpdate(IEntity entity, float deltaTime)
        {
            var targetPos = _target.position;
            var rootPosition = _root.position;

            var direction = targetPos - rootPosition;
            entity.GetMovementDirection().Value = direction;
            entity.GetRotation().Value = CalculateRotation(direction);
        }

        private Quaternion CalculateRotation(Vector3 direction)
        {
            direction.y = 0f;
            if (direction == Vector3.zero) 
                return _root.rotation;
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            return Quaternion.Euler(0f, lookRotation.eulerAngles.y, 0f);
        }
    }
}