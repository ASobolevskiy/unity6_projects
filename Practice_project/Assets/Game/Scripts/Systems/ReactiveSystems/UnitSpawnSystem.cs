using System.Collections.Generic;
using Entitas;
using Entitas.Unity;
using UnityEngine;

namespace Game.Systems
{
    public class UnitSpawnSystem : ReactiveSystem<EventsEntity>
    {
        private readonly Contexts _contexts;
        
        public UnitSpawnSystem(Contexts contexts) : base(contexts.events)
        {
            _contexts = contexts;
        }

        protected override ICollector<EventsEntity> GetTrigger(IContext<EventsEntity> context)
        {
            var matches = new[]
            {
                EventsMatcher.SpawnRequested
            };

            return context.CreateCollector(EventsMatcher.AllOf((matches)));
        }

        protected override bool Filter(EventsEntity entity)
        {
            return entity.isUnit
                   && entity.isSpawnRequested
                   && (entity.isBlueTeam || entity.isRedTeam)
                   && entity.hasPosition
                   && entity.hasRotation
                   && entity.hasUnitPrefab;
        }

        protected override void Execute(List<EventsEntity> entities)
        {
            foreach (var entity in entities)
            {
                var prefab = entity.unitPrefab.Value;
                var gameEntity = _contexts.game.CreateEntity();
                gameEntity.AddPosition(entity.position.Value);
                gameEntity.AddRotation(entity.rotation.Value);
                gameEntity.isUnit = entity.isUnit;
                gameEntity.isRedTeam = entity.isRedTeam;
                gameEntity.isBlueTeam = entity.isBlueTeam;
                gameEntity.isMovable = true;
                gameEntity.AddMovementDirection(Vector3.zero);
                gameEntity.AddHealth(prefab.GetHitPoints());
                gameEntity.AddMoveSpeed(prefab.GetMoveSpeed());

                //TODO use pools
                var go = entity.unitPrefab.Value.gameObject;
                var gameObject = Object.Instantiate(go,
                    gameEntity.position.Value,
                    gameEntity.rotation.Value);
                gameEntity.AddSceneView(gameObject);
                gameObject.Link(gameEntity);
                
                entity.Destroy();
            }
        }
    }
}