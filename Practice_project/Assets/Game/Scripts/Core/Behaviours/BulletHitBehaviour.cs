using Atomic.Entities;
using Game.Core.Trigger;
using UnityEngine;

namespace Game.Core.Behaviours
{
    public class BulletHitBehaviour : IEntityInit, IEntityDispose
    {
        private TriggerEventReceiver _triggerReceiver;
        
        public void Init(IEntity entity)
        {
            _triggerReceiver = entity.GetTriggerReceiver();
            
            _triggerReceiver.OnTriggerEntered += OnTriggerEntered;
        }

        private void OnTriggerEntered(Collider other)
        {
            if (other.TryGetComponent(out IEntity hittedEntity))
            {
                hittedEntity.GetTakeDamageAction().Invoke(1);
            }
        }

        public void Dispose(IEntity entity)
        {
            _triggerReceiver.OnTriggerEntered -= OnTriggerEntered;
        }
    }
}