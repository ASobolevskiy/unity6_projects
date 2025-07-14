using Atomic.Entities;
using Game.Visual.Vfx.Behaviours;
using UnityEngine;

namespace Game.Visual.Vfx.Installers
{
    public sealed class ZombieVfxInstaller : SceneEntityInstallerBase
    {
        [SerializeField]
        private ParticleSystem _zombieTakeDamagePSystem;
        public override void Install(IEntity entity)
        {
            entity.SetZombieTakeDamagePSystem(_zombieTakeDamagePSystem);

            entity.AddBehaviour(new ZombieVfxBehaviour());
        }
    }
}