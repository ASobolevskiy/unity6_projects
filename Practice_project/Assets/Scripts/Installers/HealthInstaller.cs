using System;
using Atomic.Elements;
using Atomic.Entities;
using Mechanics;
using UnityEngine;

namespace AtomicPlayground
{
    [Serializable]
    public class HealthInstaller : IEntityInstaller
    {
        [SerializeField]
        private int hitPoints = 100;
        public void Install(IEntity entity)
        {
            entity.SetHitPoints(new ReactiveVariable<int>(hitPoints));
            entity.SetIsDead(new ReactiveVariable<bool>());
            entity.SetTakeDamageAction(new BaseEvent<int>());

            entity.AddBehaviour(new HealthBehaviour());
        }
    }
}