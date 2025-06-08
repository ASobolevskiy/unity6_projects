using Atomic.Entities;
using Game.Behaviours.Visual.Animations;
using Game.Utils;
using UnityEngine;

namespace Game.Installers.Visual.Animations
{
    public sealed class PlayerAnimationsInstaller : SceneEntityInstallerBase
    {
        [SerializeField]
        private Animator _animator;

        [SerializeField]
        private AnimationEventDispatcher _dispatcher;
        
        public override void Install(IEntity entity)
        {
            entity.SetAnimator(_animator);
            entity.SetAnimationEventDispatcher(_dispatcher);

            entity.AddBehaviour(new PlayerMovementAnimationBehaviour());
        }
    }
}