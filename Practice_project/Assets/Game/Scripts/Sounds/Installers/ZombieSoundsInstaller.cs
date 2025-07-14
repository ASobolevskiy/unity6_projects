using Atomic.Entities;
using Game.Sounds.Behaviours;
using UnityEngine;
using UnityEngine.Serialization;

namespace Game.Sounds.Installers
{
    public class ZombieSoundsInstaller : SceneEntityInstallerBase
    {
        [SerializeField]
        private AudioSource _audioSource;

        [SerializeField]
        private AudioClip _zombieHitSound;

        [SerializeField]
        private AudioClip _zombieDeathSound;
        
        public override void Install(IEntity entity)
        {
            entity.SetAudioSource(_audioSource);
            entity.SetZombieHitSound(_zombieHitSound);
            entity.SetZombieDeathSound(_zombieDeathSound);

            entity.AddBehaviour(new ZombieHitSoundBehaviour());
            entity.AddBehaviour(new ZombieDeathSoundBehaviour());
        }
    }
}