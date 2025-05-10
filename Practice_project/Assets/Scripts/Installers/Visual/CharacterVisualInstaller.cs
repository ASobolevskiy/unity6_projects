using System;
using Atomic.Entities;
using AtomicPlayground.Utils;
using Mechanics.Visual;
using UnityEngine;

namespace AtomicPlayground.Visual
{
    [Serializable]
    public class CharacterVisualInstaller : SceneEntityInstallerBase
    {
        [SerializeField]
        private Animator animator;

        [SerializeField]
        private AnimationEventDispatcher animationEventDispatcher;
        public override void Install(IEntity entity)
        {
            entity.SetAnimator(animator);
            entity.SetAnimationEventDispatcher(animationEventDispatcher);

            entity.AddBehaviour(new CharacterMoveAnimationBehaviour());
            entity.AddBehaviour(new CharacterDeathAnimationBehaviour());
            entity.AddBehaviour(new CharacterShootAnimationBehaviour());
        }
    }
}