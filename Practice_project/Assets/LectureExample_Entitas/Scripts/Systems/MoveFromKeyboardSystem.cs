using Entitas;

namespace Game.Systems
{
    public class MoveFromKeyboardSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _movables;

        public MoveFromKeyboardSystem(Contexts contexts)
        {
            var matches = new[]
            {
                GameMatcher.Movable,
                GameMatcher.KeyboardMovable,
                GameMatcher.Position,
                GameMatcher.MoveDirection,
                GameMatcher.MoveSpeed
            };
            _movables = contexts.game.GetGroup(GameMatcher.AllOf(matches));
        }

        public void Execute()
        {
            var deltaTime = UnityEngine.Time.deltaTime;
            var direction = MoveInput.GetDirection();
            foreach (var entity in _movables.GetEntities())
            {
                if(!entity.isMovable)
                    continue;
                var moveSpeed = entity.moveSpeed.Value;
                var position = entity.position.Value;

                position += direction * (moveSpeed * deltaTime);
                
                entity.ReplacePosition(position);
                entity.ReplaceMoveDirection(direction);
            }
        }
    }
}