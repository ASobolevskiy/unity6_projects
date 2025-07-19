using System.Collections.Generic;
using Entitas;

namespace Game.Systems
{
    public class HealthSystem : ReactiveSystem<GameEntity>
    {
        public HealthSystem(IContext<GameEntity> context) : base(context)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.Health);
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.hasHealth;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var entity in entities)
            {
                if (entity.health.Value <= 0)
                    entity.isDeadOrDestroyed = true;
            }
        }
    }
}