using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;
using Game.Utils;

namespace Game.Systems.Bullet
{
    public class BulletSpawnSystem : IContextEnable, IContextDisable
    {
        private BaseEvent<BulletSpawnArguments> _bulletSpawnRequest;
        private BulletSystemData _data;
        
        public void Enable(IContext context)
        {
            _bulletSpawnRequest = context.GetBulletSpawRequest();
            _data = context.GetBulletSystemData();

            _bulletSpawnRequest.Subscribe(HandleBulletSpawnRequested);
        }

        private void HandleBulletSpawnRequested(BulletSpawnArguments args)
        {
            var bullet = _data.BulletPool.TakeFromPool();
            bullet.GetBulletTransform().position = args.SpawnPoint;
            bullet.GetBulletDirection().Value = args.MoveDirection;
        }

        public void Disable(IContext context)
        {
            _bulletSpawnRequest.Unsubscribe(HandleBulletSpawnRequested);
        }
    }
}