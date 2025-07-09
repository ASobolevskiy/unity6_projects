using System;
using Atomic.Elements;
using Atomic.Entities;
using Unity.VisualScripting;
using UnityEngine;

namespace Game.Core.Behaviours
{
    public class AttackBehaviour : IEntityInit, IEntityUpdate, IEntityDispose
    {
        private const float ATTACK_DISTANCE_THRESHOLD = 0.5f;
        private IEvent _attackRequest;
        private AndExpression _canAttack;
        private Transform _target;
        private Transform _root;
        private ReactiveVariable<float> _attackCooldown;
        private ReactiveVariable<bool> _isAttackDelaying;
        private ReactiveVariable<bool> _isInAttackRange;
        private ReactiveVariable<float> _attackDistance;
        private ReactiveVariable<bool> _isAttacking;
        private ReactiveVariable<Transform> _attackPoint;
        private IEvent _hitAction;
        private IEvent _hitEvent;
        private ReactiveVariable<LayerMask> _targetLayers;
        private ReactiveVariable<int> _damage;
        private IEvent _attackFinished;
        
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
            _attackDistance = entity.GetAttackDistance();
            _isAttacking = entity.GetIsAttacking();
            _attackPoint = entity.GetAttackPoint();
            _hitAction = entity.GetHitAction();
            _hitEvent = entity.GetHitEvent();
            _targetLayers = entity.GetTargetLayer();
            _damage = entity.GetDamage();
            _attackFinished = entity.GetAttackFinished();

            _hitAction.Subscribe(OnHitAction);
            _attackFinished.Subscribe(OnAttackFinished);
        }

        

        public void OnUpdate(IEntity entity, float deltaTime)
        {
            CheckIfInAttackRange();
            HandleAttackDelayTimer(deltaTime);


            if (!_canAttack.Invoke())
                return;
            
            _attackRequest.Invoke();
            _isAttacking.Value = true;
            _coolDownTimer = _attackCooldown.Value;
            _isAttackDelaying.Value = true;
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
            var sqrDistance = _attackDistance.Value * _attackDistance.Value;
            var sqrMagnitude = (_target.position - _root.position).sqrMagnitude;
            _isInAttackRange.Value = Math.Abs(sqrMagnitude - sqrDistance) < ATTACK_DISTANCE_THRESHOLD;
        }
        
        private void OnHitAction()
        {
            var colliders = Physics.OverlapSphere(_attackPoint.Value.position, 1f, _targetLayers.Value);
            foreach (var other in colliders)
            {
                if (other.TryGetComponent(out IEntity otherEntity))
                {
                    otherEntity.GetTakeDamageAction().Invoke(_damage.Value);
                    _hitEvent.Invoke();
                }
            }
        }
        
        private void OnAttackFinished()
        {
            _isAttacking.Value = false;
        }

        public void Dispose(IEntity entity)
        {
            _hitAction.Unsubscribe(OnHitAction);
            _attackFinished.Unsubscribe(OnAttackFinished);
        }
    }
}