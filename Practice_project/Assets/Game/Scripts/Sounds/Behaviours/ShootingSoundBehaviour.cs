using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game.Sounds.Behaviours
{
    public class ShootingSoundBehaviour : IEntityInit, IEntityDispose
    {
        private AudioSource _audioSource;
        private AudioClip _rifleShotSound;
        private AudioClip _rifleDryShotSound;
        private IEvent _shootEvent;
        private IEvent _dryShotEvent;
        
        public void Init(IEntity entity)
        {
            _audioSource = entity.GetAudioSource();
            _rifleShotSound = entity.GetRifleShotSound();
            _rifleDryShotSound = entity.GetRifleDryShotSound();
            _shootEvent = entity.GetShootEvent();
            _dryShotEvent = entity.GetDryShotEvent();

            _shootEvent.Subscribe(HandleShotHappened);
            _dryShotEvent.Subscribe(HandleDryShotHappened);
        }

        private void HandleDryShotHappened()
        {
            _audioSource.PlayOneShot(_rifleDryShotSound);
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