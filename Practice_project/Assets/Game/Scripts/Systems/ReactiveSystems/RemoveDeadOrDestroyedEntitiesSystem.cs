using System;
using System.Collections.Generic;
using Entitas;

namespace Game.Systems
{
    public class RemoveDeadOrDestroyedEntitiesSystem : ReactiveSystem<GameEntity>
    {
        public RemoveDeadOrDestroyedEntitiesSystem(IContext<GameEntity> context) : base(context)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.DeadOrDestroyed);
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.isDeadOrDestroyed;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var entity in entities)
            {
                entity.Destroy();
            }
        }
    }
}