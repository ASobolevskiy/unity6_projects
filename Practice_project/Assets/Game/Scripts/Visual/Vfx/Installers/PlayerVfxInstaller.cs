using Atomic.Entities;
using Game.Visual.Vfx.Behaviours;
using UnityEngine;

namespace Game.Visual.Vfx.Installers
{
    public sealed class PlayerVfxInstaller : SceneEntityInstallerBase
    {
        [SerializeField]
        private ParticleSystem _bulletExplosion;

        [SerializeField]
        private ParticleSystem _playerTakeDamagePSystem;
        
        public override void Install(IEntity entity)
        {
            entity.SetBulletExplosionPSystem(_bulletExplosion);
            entity.SetPlayerTakeTamagePSystem(_playerTakeDamagePSystem);

            entity.AddBehaviour(new PlayerVfxBehaviour());
        }
    }
}