using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game.Visual.Animations.Behaviours
{
    public sealed class PlayerDeathAnimationBehaviour : IEntityInit, IEntityDispose
    {
        private static readonly int s_isDead = Animator.StringToHash("IsDead");
        private Animator _animator;
        private ReactiveVariable<bool> _isDead;

        public void Init(IEntity entity)
        {
            _animator = entity.GetAnimator();
            _isDead = entity.GetIsDead();
            
            _animator.SetBool(s_isDead, _isDead.Value);
            _isDead.OnValueChanged += HandleIsDeadChanged;
        }

        private void HandleIsDeadChanged(bool isDead)
        {
            _animator.SetBool(s_isDead, isDead);
        }

        public void Dispose(IEntity entity)
        {
            _isDead.Unsubscribe(HandleIsDeadChanged);
        }
    }
}