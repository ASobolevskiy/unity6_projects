using System;
using Atomic.Elements;
using Atomic.Entities;
using Mechanics;
using UnityEngine;

namespace AtomicPlayground
{
    [Serializable]
    public class MoveInstaller : IEntityInstaller
    {
        [SerializeField]
        private Transform rootTransform;

        [SerializeField]
        private float moveSpeed = 5f;

        [SerializeField]
        private Vector3 moveDirection = Vector3.zero;
        
        public void Install(IEntity entity)
        {
            entity.SetRootTransform(rootTransform);
            entity.SetMoveSpeed(moveSpeed);
            entity.SetMoveDirection(moveDirection);
            entity.SetIsMoving(new ReactiveVariable<bool>());
            
            entity.AddBehaviour(new MoveBehaviour());
        }
    }
}