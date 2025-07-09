using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game.Sounds.Behaviours
{
    public class ZombieHitSoundBehaviour : IEntityInit, IEntityDispose
    {
        private AudioSource _audioSource;
        private AudioClip _zombieHitSound;
        private IEvent _hitEvent;
        
        public void Init(IEntity entity)
        {
            _audioSource = entity.GetAudioSource();
            _zombieHitSound = entity.GetZombieHitSound();
            _hitEvent = entity.GetHitEvent();

            _hitEvent.Subscribe(OnHitEvent);
        }

        private void OnHitEvent()
        {
            _audioSource.PlayOneShot(_zombieHitSound);
        }

        public void Dispose(IEntity entity)
        {
            _hitEvent.Unsubscribe(OnHitEvent);
        }
    }
}