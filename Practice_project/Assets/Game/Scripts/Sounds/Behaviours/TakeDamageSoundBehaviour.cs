using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game.Sounds.Behaviours
{
    public class TakeDamageSoundBehaviour : IEntityInit, IEntityDispose
    {
        private AudioSource _audioSource;
        private AudioClip _painSound;
        private AudioClip _deathSound;
        private IEvent _takeDamageEvent;
        private ReactiveVariable<bool> _isDead;
        
        public void Init(IEntity entity)
        {
            _audioSource = entity.GetAudioSource();
            _painSound = entity.GetPainSound();
            _deathSound = entity.GetDeathSound();
            _takeDamageEvent = entity.GetTakeDamageEvent();
            _takeDamageEvent.Subscribe(HandleTakeDamageHappened);
            _isDead = entity.GetIsDead();
            _isDead.Observe(HandleDeath);
        }

        private void HandleDeath(bool isDead)
        {
            if (!isDead) 
                return;
            
            if(_audioSource.isPlaying)
                _audioSource.Stop();
            _audioSource.PlayOneShot(_deathSound);
        }

        private void HandleTakeDamageHappened()
        {
            if(!_audioSource.isPlaying)
                _audioSource.PlayOneShot(_painSound);
        }

        public void Dispose(IEntity entity)
        {
            _takeDamageEvent.Unsubscribe(HandleTakeDamageHappened);
        }
    }
}