using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;
using Game.Context;

namespace Game.Systems.Health
{
    public class HealthTrackSystem : IContextEnable, IContextDisable
    {
        private IContext _playerContext;
        private IEntity _player;
        private ReactiveVariable<int> _hitPoints;
        private ReactiveVariable<bool> _isDead;

        public void Enable(IContext context)
        {
            _playerContext = context;
            _player = context.GetPlayer().Value;
            _hitPoints = _player.GetHitpoints();
            _isDead = _player.GetIsDead();
            
            _hitPoints.Observe(ObserveHitPoints);
            _isDead.Subscribe(OnPlayerDied);
        }

        private void OnPlayerDied(bool isDead)
        {
            if (isDead)
                GameContext.Instance.GetIsGameOver().Value = true;
        }

        private void ObserveHitPoints(int hitPoints)
        {
            _playerContext.GetHitpoints().Value = hitPoints;
        }

        public void Disable(IContext context)
        {
            _hitPoints.Unsubscribe(ObserveHitPoints);
            _isDead.Unsubscribe(OnPlayerDied);
        }
    }
}