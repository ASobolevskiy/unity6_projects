using Atomic.Elements;
using Atomic.Entities;
using Game.Utils;
using UnityEngine;

namespace Game.Visual.Animations.Behaviours
{
    public class EnemyAttackAnimationBehaviour : IEntityInit, IEntityDispose
    {
        private static readonly int s_attack = Animator.StringToHash("Attack");
        private const string TAG_HIT = "checkHits";
        private const string TAG_FINISHED = "attackFinished";
        
        private Animator _animator;
        private AnimationEventDispatcher _animationEventDispatcher;
        private AndExpression _canAttack;
        private IEvent _attackRequest;
        private IEvent _hitAction;
        private IEvent _attackFinished;

        public void Init(IEntity entity)
        {
            _animator = entity.GetAnimator();
            _animationEventDispatcher = entity.GetAnimationEventDispatcher();
            _canAttack = entity.GetCanAttack();
            _attackRequest = entity.GetAttackRequest();
            _hitAction = entity.GetHitAction();
            _attackFinished = entity.GetAttackFinished();

            _animationEventDispatcher.OnEventReceived += OnAnimationEventReceived;
            _attackRequest.Subscribe(OnAttackRequested);
        }

        private void OnAnimationEventReceived(string tag)
        {
            switch (tag)
            {
                case TAG_HIT:
                    _hitAction.Invoke();
                    break;
                case TAG_FINISHED:
                    _attackFinished.Invoke();
                    break;
            }
        }

        private void OnAttackRequested()
        {
            if (!_canAttack.Invoke())
                return;
            _animator.SetTrigger(s_attack);
        }

        public void Dispose(IEntity entity)
        {
            _attackRequest.Unsubscribe(OnAttackRequested);
            _animationEventDispatcher.OnEventReceived -= OnAnimationEventReceived;
        }
    }
}