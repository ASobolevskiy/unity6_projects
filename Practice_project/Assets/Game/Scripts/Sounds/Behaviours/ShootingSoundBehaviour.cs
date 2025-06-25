using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game.Sounds.Behaviours
{
    public class ShootingSoundBehaviour : IEntityInit, IEntityDispose
    {
        private AudioSource _audioSource;
        private AudioClip _rifleShotSound;
        private IEvent _shootEvent;
        
        public void Init(IEntity entity)
        {
            _audioSource = entity.GetAudioSource();
            _rifleShotSound = entity.GetRifleShotSound();
            _shootEvent = entity.GetShootEvent();

            _shootEvent.Subscribe(HandleShotHappened);
        }

        private void HandleShotHappened()
        {
            _audioSource.PlayOneShot(_rifleShotSound);
        }

        public void Dispose(IEntity entity)
        {
            _shootEvent.Unsubscribe(HandleShotHappened);
        }
    }
}