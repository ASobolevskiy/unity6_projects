using Atomic.Elements;
using Atomic.Entities;

namespace Game.Behaviours
{
    public sealed class HealthBehaviour : IEntityInit, IEntityDispose
    {
        private ReactiveVariable<int> _hitPoints;
        private ReactiveVariable<bool> _isDead;
        private BaseEvent<int> _takeDamageAction;

        public void Init(IEntity entity)
        {
            _hitPoints = entity.GetHitpoints();
            _isDead = entity.GetIsDead();
            _takeDamageAction = entity.GetTakeDamageAction();

            _takeDamageAction.Subscribe(HandleTakeDamage);
        }

        private void HandleTakeDamage(int damage)
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
            _takeDamageAction.Unsubscribe(HandleTakeDamage);
        }
    }
}