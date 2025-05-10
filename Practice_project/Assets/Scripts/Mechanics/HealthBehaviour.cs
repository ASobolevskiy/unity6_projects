using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Mechanics
{
    public class HealthBehaviour : IEntityInit, IEntityDispose
    {
        private ReactiveVariable<int> _hitPoints;
        private ReactiveVariable<bool> _isDead;
        private BaseEvent<int> _takeDamageAction;

        public void Init(IEntity entity)
        {
            _hitPoints = entity.GetHitPoints();
            _isDead = entity.GetIsDead();
            _takeDamageAction = entity.GetTakeDamageAction();
            _takeDamageAction.Subscribe(HandleDamageTaken);
            _hitPoints.Subscribe(HandleHitPointsChanged);
        }

        private void HandleHitPointsChanged(int hitPoints)
        {
            Debug.Log($"New hit points: {hitPoints}");
        }

        private void HandleDamageTaken(int damage)
        {
            if (_isDead.Value)
                return;
            _hitPoints.Value -= damage;
            if (_hitPoints.Value <= 0)
            {
                _isDead.Value = true;
            }
        }

        public void Dispose(IEntity entity)
        {
            _takeDamageAction.Unsubscribe(HandleDamageTaken);
            _hitPoints.Unsubscribe(HandleHitPointsChanged);
        }
    }
}