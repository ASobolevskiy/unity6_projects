using Atomic.Contexts;
using Atomic.Entities;
using Game.Context;
using Game.Core.Trigger;
using UnityEngine;

namespace Game.Core.Behaviours
{
    public class BulletHitBehaviour : IEntityInit, IEntityDispose
    {
        private TriggerEventReceiver _triggerReceiver;
        private IEntity _entity;
        
        public void Init(IEntity entity)
        {
            _triggerReceiver = entity.GetTriggerReceiver();
            _entity = entity;
            
            _triggerReceiver.OnTriggerEntered += OnTriggerEntered;
        }

        private void OnTriggerEntered(Collider other)
        {
            if (!other.TryGetComponent(out IEntity hittedEntity)) 
                return;
            if (!hittedEntity.TryGetIsDead(out var isDead) || isDead.Value) 
                return;
            hittedEntity.GetTakeDamageAction().Invoke(1);
            GameContext.Instance.GetEntityDestroyRequest().Invoke(_entity);
        }

        public void Dispose(IEntity entity)
        {
            _triggerReceiver.OnTriggerEntered -= OnTriggerEntered;
        }
    }
}