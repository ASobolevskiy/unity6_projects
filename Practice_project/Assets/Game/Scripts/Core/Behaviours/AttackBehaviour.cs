using System;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game.Core.Behaviours
{
    public class AttackBehaviour : IEntityInit, IEntityUpdate, IEntityDispose
    {
        private IEvent _attackRequest;
        private AndExpression _canAttack;
        private Transform _target;
        private Transform _root;
        private ReactiveVariable<float> _attackCooldown;
        private ReactiveVariable<bool> _isAttackDelaying;
        private ReactiveVariable<bool> _isInAttackRange;
        
        private float _coolDownTimer;
        
        public void Init(IEntity entity)
        {
            _attackRequest = entity.GetAttackRequest();
            _canAttack = entity.GetCanAttack();
            _target = entity.GetTarget();
            _root = entity.GetRootTransform();
            _attackCooldown = entity.GetAttackCooldown();
            _isAttackDelaying = entity.GetIsAttackDelaying();
            _isInAttackRange = entity.GetIsInAttackRange();
            
            _canAttack.Append(() => _isInAttackRange.Value);
            _canAttack.Append(() => !_isAttackDelaying.Value);
        }

        public void OnUpdate(IEntity entity, float deltaTime)
        {
            CheckIfInAttackRange();
            HandleAttackDelayTimer(deltaTime);
            

            if (_canAttack.Invoke())
            {
                _attackRequest.Invoke();
                _coolDownTimer = _attackCooldown.Value;
                _isAttackDelaying.Value = true;
            }
        }

        private void HandleAttackDelayTimer(float deltaTime)
        {
            if (!_isAttackDelaying.Value)
                return;
            _coolDownTimer -= deltaTime;
            if (_coolDownTimer <= 0)
            {
                _isAttackDelaying.Value = false;
            }
        }

        private void CheckIfInAttackRange()
        {
            var sqrMagnitude = (_target.position - _root.position).sqrMagnitude;
            _isInAttackRange.Value = Math.Abs(sqrMagnitude - 1f) < 0.5f;
        }

        public void Dispose(IEntity entity)
        {
            
        }
    }
}