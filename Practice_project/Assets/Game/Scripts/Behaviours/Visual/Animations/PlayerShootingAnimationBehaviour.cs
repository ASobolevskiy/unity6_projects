using Atomic.Elements;
using Atomic.Entities;
using Game.Utils;
using UnityEngine;

namespace Game.Behaviours.Visual.Animations
{
    public sealed class PlayerShootingAnimationBehaviour : IEntityInit, IEntityDispose
    {
        private static readonly int s_shoot = Animator.StringToHash("Shoot");
        private const string TAG_SHOOT = "shoot";

        private Animator _animator;
        private AnimationEventDispatcher _animationEventDispatcher;
        
        private IEvent _shootRequest;
        private IEvent _shootAction;

        private ReactiveVariable<bool> _isReloading;
        public void Init(IEntity entity)
        {
            _animator = entity.GetAnimator();
            _animationEventDispatcher = entity.GetAnimationEventDispatcher();
            _isReloading = entity.GetIsShotDelaying();
            
            _shootRequest = entity.GetShootRequest();
            _shootAction = entity.GetShootAction();

            _animationEventDispatcher.OnEventReceived += OnAnimationEventReceived;
            _shootRequest.Subscribe(OnShootRequested);
        }
        
        private void OnAnimationEventReceived(string tag)
        {
            if (tag.Equals(TAG_SHOOT))
                _shootAction.Invoke();
        }

        private void OnShootRequested()
        {
            if (_isReloading.Value)
                return;
            _animator.SetTrigger(s_shoot);
        }

        public void Dispose(IEntity entity)
        {
            _shootRequest.Unsubscribe(OnShootRequested);
            _animationEventDispatcher.OnEventReceived -= OnAnimationEventReceived;
        }
    }
}