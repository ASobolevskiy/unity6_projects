using Atomic.Elements;
using Atomic.Entities;
using Game.Behaviours;
using UnityEngine;

namespace Game.Installers
{
    public sealed class HealthInstaller : SceneEntityInstallerBase
    {
        [SerializeField]
        private int _hitPoints;
        
        public override void Install(IEntity entity)
        {
            entity.SetHitpoints(_hitPoints);
            entity.SetIsDead(new ReactiveVariable<bool>());
            entity.SetTakeDamageAction(new BaseEvent<int>());

            entity.AddBehaviour(new HealthBehaviour());
        }
    }
}