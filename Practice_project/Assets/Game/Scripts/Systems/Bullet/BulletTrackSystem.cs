using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;

namespace Game.Systems.Bullet
{
    public class BulletTrackSystem :IContextEnable, IContextDisable
    {
        private IContext _playerContext;
        private IEntity _player;
        private ReactiveVariable<int> _maxBullets;
        private ReactiveVariable<int> _currentBullets;
        
        public void Enable(IContext context)
        {
            _playerContext = context;
            _player = context.GetPlayer().Value;
            _maxBullets = _player.GetMaximumAmmo();
            _currentBullets = _player.GetCurrentAmmo();
            
            _maxBullets.Observe(ObserveMaxBullets);
            _currentBullets.Observe(ObserveCurrentBullets);
        }

        private void ObserveCurrentBullets(int currentBullets)
        {
            _playerContext.GetCurrentBullets().Value = currentBullets;
        }

        private void ObserveMaxBullets(int maxBullets)
        {
            _playerContext.GetMaxBullets().Value = maxBullets;
        }

        public void Disable(IContext context)
        {
            _maxBullets.Unsubscribe(ObserveMaxBullets);
            _currentBullets.Unsubscribe(ObserveCurrentBullets);
        }
    }
}