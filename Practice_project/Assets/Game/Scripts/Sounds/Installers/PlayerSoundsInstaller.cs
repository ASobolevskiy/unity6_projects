using Atomic.Entities;
using Game.Sounds.Behaviours;
using UnityEngine;

namespace Game.Sounds.Installers
{
    public class PlayerSoundsInstaller : SceneEntityInstallerBase
    {
        [SerializeField]
        private AudioSource _audioSource;

        [SerializeField]
        private AudioClip _rifleShotSound;

        [SerializeField]
        private AudioClip _rifleDryShotSound;

        [SerializeField]
        private AudioClip _humanPainSound;

        [SerializeField]
        private AudioClip _humanDeathSound;
        
        public override void Install(IEntity entity)
        {
            entity.SetAudioSource(_audioSource);
            entity.SetRifleShotSound(_rifleShotSound);
            entity.SetRifleDryShotSound(_rifleDryShotSound);
            entity.SetPainSound(_humanPainSound);
            entity.SetDeathSound(_humanDeathSound);

            entity.AddBehaviour(new ShootingSoundBehaviour());
            entity.AddBehaviour(new TakeDamageSoundBehaviour());
        }
    }
}