using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;

namespace Game.Systems.Enemies
{
    public class EnemyDestroySystem : IContextEnable, IContextDisable
    {
        private EnemySystemData _data;
        private BaseEvent<IEntity> _enemyDestroyRequest;
        public void Enable(IContext context)
        {
            _data = context.GetEnemySystemData();
            _enemyDestroyRequest = context.GetEntityDestroyRequest();

            _enemyDestroyRequest.Subscribe(HandleEnemyDestroyRequested);
        }

        private void HandleEnemyDestroyRequested(IEntity entity)
        {
            if (!entity.HasEnemyTag()) 
                return;
            
            entity.GetIsDead().Value = false;
            entity.GetIsAttacking().Value = false;
            entity.GetIsMoving().Value = false;
            _data.EnemyPool.ReturnToPool(entity);
        }

        public void Disable(IContext context)
        {
            _enemyDestroyRequest.Unsubscribe(HandleEnemyDestroyRequested);
        }
    }
}