using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;

namespace Game.Systems.Bullet
{
    public class BulletDestroySystem : IContextEnable, IContextDisable
    {
        private BulletSystemData _data;
        private BaseEvent<IEntity> _bulletDestroyRequest;

        public void Enable(IContext context)
        {
            _data = context.GetBulletSystemData();
            _bulletDestroyRequest = context.GetEntityDestroyRequest();

            _bulletDestroyRequest.Subscribe(HandleBulletDestroyRequested);
        }

        private void HandleBulletDestroyRequested(IEntity entity)
        {
            if(entity.HasBulletTag())
                _data.BulletPool.ReturnToPool(entity);
        }

        public void Disable(IContext context)
        {
            _bulletDestroyRequest.Unsubscribe(HandleBulletDestroyRequested);
        }
    }
}