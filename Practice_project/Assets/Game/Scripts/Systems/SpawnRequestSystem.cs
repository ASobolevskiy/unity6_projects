using Entitas;
using Entitas.Unity;
using UnityEngine;

namespace Game.Systems
{
    public class SpawnRequestSystem : IExecuteSystem
    {
        private readonly IGroup<EventsEntity> _spawn;
        private readonly Contexts _contexts;
        public SpawnRequestSystem(Contexts contexts)
        {
            var matches = new[]
            {
                EventsMatcher.SpawnRequest,
                EventsMatcher.Position,
                EventsMatcher.Prefab
            };

            _spawn = contexts.events.GetGroup(EventsMatcher.AllOf(matches));
            _contexts = contexts;
        }

        public void Execute()
        {
            foreach (var entity in _spawn.GetEntities())
            {
                var position = entity.position.Value;
                var prefab = entity.prefab.Value;
                var go = Object.Instantiate(prefab, position, Quaternion.identity);
                var gameEntity = _contexts.game.CreateEntity();
                gameEntity.AddPosition(position);
                gameEntity.AddMoveSpeed(5);
                gameEntity.isMovable = true;
                gameEntity.AddMoveDirection(go.transform.forward);
                gameEntity.AddSceneView(go);
                go.Link(gameEntity);

                entity.Destroy();
            }
        }
    }
}