using Entitas;

namespace Game.Systems
{
    public class MoveSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _movables;

        public MoveSystem(Contexts contexts)
        {
            var matches = new[]
            {
                GameMatcher.Movable,
                GameMatcher.Position,
                GameMatcher.MoveDirection,
                GameMatcher.MoveSpeed
            };

            _movables = contexts.game.GetGroup(GameMatcher.AllOf(matches));
        }

        public void Execute()
        {
            var deltaTime = UnityEngine.Time.deltaTime;
            foreach (var entity in _movables.GetEntities())
            {
                if(!entity.isMovable)
                    continue;
                var moveDirection = entity.moveDirection.Value.normalized;
                var moveSpeed = entity.moveSpeed.Value;
                var position = entity.position.Value;

                position += moveDirection * (moveSpeed * deltaTime);
                
                entity.ReplacePosition(position);
            }
        }
    }
}