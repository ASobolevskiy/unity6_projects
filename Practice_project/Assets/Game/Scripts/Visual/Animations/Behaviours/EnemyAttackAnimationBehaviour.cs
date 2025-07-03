using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game.Visual.Animations.Behaviours
{
    public class EnemyAttackAnimationBehaviour : IEntityInit, IEntityDispose
    {
        private Animator _animator;
        private IEvent _attackRequest;
        private static readonly int s_attack = Animator.StringToHash("Attack");

        public void Init(IEntity entity)
        {
            _animator = entity.GetAnimator();
            _attackRequest = entity.GetAttackRequest();

            _attackRequest.Subscribe(OnAttackRequested);
        }

        private void OnAttackRequested()
        {
            _animator.SetTrigger(s_attack);
        }

        public void Dispose(IEntity entity)
        {
            _attackRequest.Unsubscribe(OnAttackRequested);
        }
    }
}