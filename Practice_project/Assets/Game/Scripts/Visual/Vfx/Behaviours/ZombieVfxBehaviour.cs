using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game.Visual.Vfx.Behaviours
{
    public class ZombieVfxBehaviour : IEntityInit, IEntityDispose
    {
        private ParticleSystem _zombieTakeDamagePSystem;
        private ReactiveVariable<bool> _isDead;
        
        public void Init(IEntity entity)
        {
            _zombieTakeDamagePSystem = entity.GetZombieTakeDamagePSystem();
            _isDead = entity.GetIsDead();

            _isDead.Subscribe(HandleTakeDamageHappened);
        }

        private void HandleTakeDamageHappened(bool isDead)
        {
            if(isDead)
                _zombieTakeDamagePSystem.Play(true);
        }

        public void Dispose(IEntity entity)
        {
            _isDead.Unsubscribe(HandleTakeDamageHappened);
        }
    }
}