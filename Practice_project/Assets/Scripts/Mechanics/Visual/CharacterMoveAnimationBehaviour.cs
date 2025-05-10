using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Mechanics.Visual
{
    public class CharacterMoveAnimationBehaviour : IEntityInit, IEntityDispose
    {
        private static readonly int s_isMoving = Animator.StringToHash("IsMoving");
        
        private ReactiveVariable<bool> _isMoving;
        private Animator _animator;

        public void Init(IEntity entity)
        {
            _isMoving = entity.GetIsMoving();
            _animator = entity.GetAnimator();
            
            _animator.SetBool(s_isMoving, _isMoving.Value);
            _isMoving.Subscribe(HandleIsMovingChanged);
        }

        private void HandleIsMovingChanged(bool isMoving)
        {
            _animator.SetBool(s_isMoving, isMoving);
        }

        public void Dispose(IEntity entity)
        {
            _isMoving.Unsubscribe(HandleIsMovingChanged);
        }
    }
}