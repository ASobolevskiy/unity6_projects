using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace Game.Systems
{
    public class LinkEntityPositionToGameObjectPositionSystem : ReactiveSystem<GameEntity>
    {
        public LinkEntityPositionToGameObjectPositionSystem(Contexts contexts) : base(contexts.game)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.Position);
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.hasSceneView && entity.hasPosition;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var entity in entities)
            {
                if (entity.isBuildingBase)
                    continue;
                entity.sceneView.Value.transform.position = entity.position.Value;
            }
        }
    }
}