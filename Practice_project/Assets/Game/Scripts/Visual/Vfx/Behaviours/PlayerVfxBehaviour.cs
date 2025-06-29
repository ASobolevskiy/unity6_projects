using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game.Visual.Vfx.Behaviours
{
    public sealed class PlayerVfxBehaviour : IEntityInit, IEntityDispose
    {
        private ParticleSystem _bulletExplosionPSystem;
        private ParticleSystem _takeDamagePSystem;
        private IEvent _shootEvent;
        private IEvent _takeDamageEvent;
        public void Init(IEntity entity)
        {
            _bulletExplosionPSystem = entity.GetBulletExplosionPSystem();
            _takeDamagePSystem = entity.GetPlayerTakeTamagePSystem();
            
            _shootEvent = entity.GetShootEvent();
            _shootEvent.Subscribe(HandleShotHappened);

            _takeDamageEvent = entity.GetTakeDamageEvent();
            _takeDamageEvent.Subscribe(HandleTakeDamageHappened);
        }

        private void HandleTakeDamageHappened()
        {
            _takeDamagePSystem.Play(true);
        }

        private void HandleShotHappened()
        {
            _bulletExplosionPSystem.Play();
        }

        public void Dispose(IEntity entity)
        {
            _shootEvent.Unsubscribe(HandleShotHappened);
            _takeDamageEvent.Unsubscribe(HandleTakeDamageHappened);
        }
    }
}