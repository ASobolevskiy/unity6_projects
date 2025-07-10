using System;
using Atomic.Entities;
using Game.Core.Behaviours;
using Game.Core.Trigger;
using UnityEngine;

namespace Game.Core.Installers
{
    [Serializable]
    public sealed class BulletHitInstaller : IEntityInstaller
    {
        [SerializeField]
        private TriggerEventReceiver _triggerReceiver;
        public void Install(IEntity entity)
        {
            entity.SetTriggerReceiver(_triggerReceiver);

            entity.AddBehaviour(new BulletHitBehaviour());
        }
    }
}