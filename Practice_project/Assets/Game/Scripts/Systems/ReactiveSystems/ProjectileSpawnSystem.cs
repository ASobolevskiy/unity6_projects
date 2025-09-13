using System.Collections.Generic;
using Entitas;
using Entitas.Unity;
using UnityEngine;

namespace Game.Systems
{
    public class ProjectileSpawnSystem : ReactiveSystem<EventsEntity>
    {
        private readonly Contexts _contexts;
        
        public ProjectileSpawnSystem(Contexts contexts) : base(contexts.events)
        {
            _contexts = contexts;
        }

        protected override ICollector<EventsEntity> GetTrigger(IContext<EventsEntity> context)
        {
            var matches = new[]
            {
                EventsMatcher.ProjectileSpawnRequested
            };

            return context.CreateCollector(EventsMatcher.AllOf((matches)));
        }

        protected override bool Filter(EventsEntity entity)
        {
            return entity.isProjectile
                   && entity.isProjectileSpawnRequested
                   && (entity.isBlueTeam || entity.isRedTeam)
                   && entity.hasPosition
                   && entity.hasRotation
                   && entity.hasMovementDirection
                   && entity.hasProjectilePrefab;
        }

        protected override void Execute(List<EventsEntity> entities)
        {
            foreach (var entity in entities)
            {
                var prefab = entity.projectilePrefab.Value;
                var gameEntity = _contexts.game.CreateEntity();
                gameEntity.AddPosition(entity.position.Value);
                gameEntity.AddRotation(entity.rotation.Value);
                gameEntity.isProjectile = true;
                gameEntity.isRedTeam = entity.isRedTeam;
                gameEntity.isBlueTeam = entity.isBlueTeam;
                gameEntity.isMovable = true;
                gameEntity.AddMovementDirection(entity.movementDirection.Value);
                gameEntity.AddMoveSpeed(prefab.GetProjectileSpeed());
                
                //TODO use pools
                var go = entity.projectilePrefab.Value.gameObject;
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