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
        public override void Install(IEntity entity)
        {
            entity.SetAudioSource(_audioSource);
            entity.SetRifleShotSound(_rifleShotSound);

            entity.AddBehaviour(new ShootingSoundBehaviour());
        }
    }
}