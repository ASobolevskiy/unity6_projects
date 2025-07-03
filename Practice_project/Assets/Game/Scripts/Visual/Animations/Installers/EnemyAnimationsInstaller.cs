using Atomic.Entities;
using Game.Utils;
using Game.Visual.Animations.Behaviours;
using UnityEngine;

namespace Game.Visual.Animations.Installers
{
    public class EnemyAnimationsInstaller : SceneEntityInstallerBase
    {
        [SerializeField]
        private Animator _animator;

        [SerializeField]
        private AnimationEventDispatcher _dispatcher;
        public override void Install(IEntity entity)
        {
            entity.SetAnimator(_animator);
            entity.SetAnimationEventDispatcher(_dispatcher);

            entity.AddBehaviour(new MovementAnimationBehaviour());
            entity.AddBehaviour(new EnemyAttackAnimationBehaviour());
        }
    }
}