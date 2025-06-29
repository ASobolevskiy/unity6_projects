using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game.Visual.Animations.Behaviours
{
    public class PlayerTakeDamageAnimationBehaviour : IEntityInit, IEntityDispose
    {
        private static readonly int s_takeDamage = Animator.StringToHash("TakeDamage");
        
        private Animator _animator;
        private IEvent _takeDamageEvent;
        
        public void Init(IEntity entity)
        {
            _animator = entity.GetAnimator();
            
            _takeDamageEvent = entity.GetTakeDamageEvent();
            _takeDamageEvent.Subscribe(HandleTakeDamageHappened);
        }

        private void HandleTakeDamageHappened()
        {
            _animator.SetTrigger(s_takeDamage);
        }

        public void Dispose(IEntity entity)
        {
            _takeDamageEvent.Unsubscribe(HandleTakeDamageHappened);
        }
    }
}