using Atomic.Elements;
using Atomic.Entities;
using Game.Utils;
using UnityEngine;

namespace Game.Visual.Animations.Behaviours
{
    public class EnemyDeathAnimationBehaviour : IEntityInit, IEntityDispose
    {
        private static readonly int s_isDead = Animator.StringToHash("IsDead");
        private const string TAG_DEAD = "Dead";
        
        private Animator _animator;
        private AnimationEventDispatcher _animationEventDispatcher;
        private IEvent _enemyDead;
        private ReactiveVariable<bool> _isDead;
        public void Init(IEntity entity)
        {
            _animator = entity.GetAnimator();
            _animationEventDispatcher = entity.GetAnimationEventDispatcher();
            _enemyDead = entity.GetEnemyDeadEvent();
            _isDead = entity.GetIsDead();
            
            _animator.SetBool(s_isDead, _isDead.Value);
            
            _isDead.OnValueChanged += HandleIsDeadChanged;
            _animationEventDispatcher.OnEventReceived += OnAnimationEventReceived;
        }

        private void OnAnimationEventReceived(string tag)
        {
            if(tag.Equals(TAG_DEAD))
                _enemyDead?.Invoke();
        }

        private void HandleIsDeadChanged(bool isDead)
        {
            _animator.SetBool(s_isDead, isDead);
        }

        public void Dispose(IEntity entity)
        {
            _animationEventDispatcher.OnEventReceived -= OnAnimationEventReceived;
            _isDead.OnValueChanged -= HandleIsDeadChanged;
        }
    }
}