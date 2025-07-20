using Entitas;

namespace Game.Scripts.Systems.ExecuteSystems
{
    public class MovementSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _movables;
        
        public MovementSystem(Contexts contexts)
        {
            var matches = new[]
            {
                GameMatcher.Movable,
                GameMatcher.MoveSpeed,
                GameMatcher.MovementDirection
            };

            _movables = contexts.game.GetGroup(GameMatcher.AllOf(matches));
        }
        public void Execute()
        {
            var deltaTime = UnityEngine.Time.deltaTime;
            foreach (var entity in _movables.GetEntities())
            {
                if (!entity.isMovable) 
                    continue;
                
                var oldPosition = entity.position.Value;
                var speed = entity.moveSpeed.Value;
                var direction = entity.movementDirection.Value.normalized;
                var newPosition = oldPosition + direction * (speed * deltaTime);
                entity.ReplacePosition(newPosition);
            }
        }
    }
}