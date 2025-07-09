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

        [SerializeField]
        private float _attackDistance;

        [SerializeField]
        private Transform _attackPoint;

        [SerializeField]
        private LayerMask _targetLayers;
        
        public void Install(IEntity entity)
        {
            entity.SetDamage(_damage);
            entity.SetAttackCooldown(_attackCooldown);
            entity.SetAttackRequest(new BaseEvent());
            entity.SetCanAttack(new AndExpression());
            entity.SetIsAttackDelaying(new ReactiveVariable<bool>());
            entity.SetIsInAttackRange(new ReactiveVariable<bool>());
            entity.SetAttackDistance(_attackDistance);
            entity.SetIsAttacking(new ReactiveVariable<bool>());
            entity.SetAttackPoint(_attackPoint);
            entity.SetHitEvent(new BaseEvent());
            entity.SetHitAction(new BaseEvent());
            entity.SetTargetLayer(_targetLayers);
            entity.SetAttackFinished(new BaseEvent());

            entity.AddBehaviour(new AttackBehaviour());
        }
    }
}