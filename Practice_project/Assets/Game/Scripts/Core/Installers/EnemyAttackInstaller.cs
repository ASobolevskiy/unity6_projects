using System;
using Atomic.Elements;
using Atomic.Entities;
using Game.Core.Behaviours;
using UnityEngine;

namespace Game.Core.Installers
{
    [Serializable]
    public class EnemyAttackInstaller : IEntityInstaller
    {
        [SerializeField]
        private int _damage;

        [SerializeField]
        private float _attackCooldown;
        public void Install(IEntity entity)
        {
            entity.SetDamage(_damage);
            entity.SetAttackCooldown(_attackCooldown);
            entity.SetAttackRequest(new BaseEvent());
            entity.SetCanAttack(new AndExpression());
            entity.SetIsAttackDelaying(new ReactiveVariable<bool>());
            entity.SetIsInAttackRange(new ReactiveVariable<bool>());

            entity.AddBehaviour(new AttackBehaviour());
        }
    }
}