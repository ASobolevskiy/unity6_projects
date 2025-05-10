using Atomic.Elements;
using Atomic.Entities;
using AtomicPlayground.Utils;
using UnityEngine;

namespace Mechanics.Visual
{
    public class CharacterShootAnimationBehaviour: IEntityInit, IEntityDispose
    {
        private static readonly int s_shoot = Animator.StringToHash("Shoot");
        private static readonly string tag_shoot = "shoot";
        
        private Animator _animator;
        private AnimationEventDispatcher _animationEventDispatcher;
        
        private IEvent _shootRequest;
        private IEvent _shootAction;

        private ReactiveVariable<bool> _isReloading;
        
        public void Init(IEntity entity)
        {
            _animator = entity.GetAnimator();
            _animationEventDispatcher = entity.GetAnimationEventDispatcher();
            _isReloading = entity.GetIsReloading();
            
            _shootRequest = entity.GetShootRequest();
            _shootAction = entity.GetShootAction();

            _animationEventDispatcher.OnEventReceived += OnAnimationEventReceived;
            _shootRequest.Subscribe(OnShootRequested);
        }

        private void OnAnimationEventReceived(string tag)
        {
            if (tag.Equals(tag_shoot))
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