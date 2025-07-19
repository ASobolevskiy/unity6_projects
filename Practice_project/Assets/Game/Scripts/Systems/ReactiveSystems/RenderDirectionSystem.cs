using System;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

namespace Game.Systems.ReactiveSystems
{
    public class RenderDirectionSystem : ReactiveSystem<GameEntity>
    {
        private readonly GameContext _context;
        
        public RenderDirectionSystem(Contexts contexts) : base(contexts.game)
        {
            _context = contexts.game;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.MoveDirection);
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.hasMoveDirection && entity.hasSceneView;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var entity in entities)
            {
                var direction = entity.moveDirection.Value;
                if (direction == Vector3.zero) 
                    continue;
                var lookRotation = Quaternion.LookRotation(direction);
                entity.sceneView.Value.transform.rotation = Quaternion.Euler(0, lookRotation.eulerAngles.y, 0);

            }
        }
    }
}