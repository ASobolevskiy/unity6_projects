using System;
using Atomic.Elements;
using Atomic.Entities;
using Game.Core.Behaviours;
using UnityEngine;

namespace Game.Core.Installers
{
    [Serializable]
    public sealed class HealthInstaller : IEntityInstaller
    {
        [SerializeField]
        private int _hitPoints;
        
        public void Install(IEntity entity)
        {
            entity.SetHitpoints(_hitPoints);
            entity.SetIsDead(new ReactiveVariable<bool>());
            entity.SetTakeDamageAction(new BaseEvent<int>());
            entity.SetTakeDamageEvent(new BaseEvent());

            entity.AddBehaviour(new HealthBehaviour());
        }
    }
}