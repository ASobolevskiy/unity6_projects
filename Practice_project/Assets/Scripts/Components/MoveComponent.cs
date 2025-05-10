using System;
using AtomicPlayground.Proxy;
using UnityEngine;

namespace AtomicPlayground.Components
{
    [Serializable]
    public class MoveComponent
    {
        [SerializeField]
        private float speed = 3f;

        [SerializeField]
        private Transform root;

        private Vector3 _moveDirection;
        
        public CompositeCondition CanMove = new CompositeCondition();
        
        public void OnUpdate(float deltaTime)
        {
            if (!CanMove.IsTrue())
            {
                return;
            }
            
            root.position += _moveDirection * speed * deltaTime;
        }
        
        public void SetDirection(Vector3 direction)
        {
            _moveDirection = direction;
        }
    }
}