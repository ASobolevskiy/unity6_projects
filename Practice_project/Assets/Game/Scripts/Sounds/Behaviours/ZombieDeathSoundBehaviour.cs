using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game.Sounds.Behaviours
{
    public class ZombieDeathSoundBehaviour : IEntityInit, IEntityDispose
    {
        private AudioSource _audioSource;
        private AudioClip _zombieDeathSound;
        private ReactiveVariable<bool> _isDead;
        
        public void Init(IEntity entity)
        {
            _audioSource = entity.GetAudioSource();
            _zombieDeathSound = entity.GetZombieDeathSound();

            _isDead = entity.GetIsDead();
            _isDead.Observe(ObserveIsDead);
        }

        private void ObserveIsDead(bool isDead)
        {
            if(isDead)
                _audioSource.PlayOneShot(_zombieDeathSound);
        }

        public void Dispose(IEntity entity)
        {
            _isDead.Unsubscribe(ObserveIsDead);
        }
    }
}