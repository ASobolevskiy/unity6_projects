using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game.Core.Behaviours
{
    public class RotationBehaviour : IEntityInit, IEntityUpdate
    {
        private Transform _root;
        private ReactiveVariable<Quaternion> _rotation;
        private AndExpression _canRotate;
        public void Init(IEntity entity)
        {
            _root = entity.GetRootTransform();
            _rotation = entity.GetRotation();
            _canRotate = entity.GetCanRotate();
        }

        public void OnUpdate(IEntity entity, float deltaTime)
        {
            if(_canRotate.Invoke())
                _root.rotation = _rotation.Value;
        }
    }
}