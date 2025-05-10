using System;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Mechanics.Visual
{
    public class CharacterDeathAnimationBehaviour : IEntityInit, IEntityDispose
    {
        private static readonly int s_isDead = Animator.StringToHash("IsDead");

        private ReactiveVariable<bool> _isDead;
        private Animator _animator;
        public void Init(IEntity entity)
        {
            _isDead = entity.GetIsDead();
            _animator = entity.GetAnimator();
            
            _animator.SetBool(s_isDead, _isDead.Value);
            _isDead.Subscribe(HandleIsDeadChanged);
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