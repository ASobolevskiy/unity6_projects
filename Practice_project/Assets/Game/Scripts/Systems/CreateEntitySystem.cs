using Entitas;
using UnityEngine;

namespace Game.Systems
{
    public class CreateEntitySystem : IInitializeSystem
    {
        private readonly Contexts _contexts;

        public CreateEntitySystem(Contexts contexts)
        {
            _contexts = contexts;
        }

        public void Initialize()
        {
            var entity = _contexts.game.CreateEntity();
            entity.isUnit = true;
            entity.isMovable = true;
            entity.AddPosition(Vector3.zero);
            entity.AddMoveDirection(Vector3.zero);
            entity.AddMoveSpeed(1);
        }
    }
}