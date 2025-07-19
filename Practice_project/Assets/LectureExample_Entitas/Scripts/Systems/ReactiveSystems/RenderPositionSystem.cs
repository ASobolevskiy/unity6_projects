using System.Collections.Generic;
using Entitas;

namespace Game.Systems.ReactiveSystems
{
    public class RenderPositionSystem : ReactiveSystem<GameEntity>
    {
        public RenderPositionSystem(Contexts contexts) : base(contexts.game)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.Position);
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.hasPosition && entity.hasSceneView;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (GameEntity e in entities)
            {
                e.sceneView.Value.transform.position = e.position.Value;
            }
        }
    }
}