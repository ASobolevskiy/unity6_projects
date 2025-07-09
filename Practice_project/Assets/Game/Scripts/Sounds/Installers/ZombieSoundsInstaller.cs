using Atomic.Entities;
using Game.Sounds.Behaviours;
using UnityEngine;

namespace Game.Sounds.Installers
{
    public class ZombieSoundsInstaller : SceneEntityInstallerBase
    {
        [SerializeField]
        private AudioSource _audioSource;

        [SerializeField]
        private AudioClip _zombieHitSound;
        public override void Install(IEntity entity)
        {
            entity.SetAudioSource(_audioSource);
            entity.SetZombieHitSound(_zombieHitSound);

            entity.AddBehaviour(new ZombieHitSoundBehaviour());
        }
    }
}