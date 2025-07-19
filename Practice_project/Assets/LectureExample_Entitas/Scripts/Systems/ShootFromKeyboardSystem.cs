using Entitas;

namespace Game.Systems
{
    public class ShootFromKeyboardSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _shooters;

        public ShootFromKeyboardSystem(Contexts contexts)
        {
            var matches = new[]
            {
                GameMatcher.CanShoot,
                GameMatcher.CanShootFromKeyboard
            };
            _shooters = contexts.game.GetGroup(GameMatcher.AllOf(matches));
        }

        public void Execute()
        {
            var isFirePressed = FireInput.IsFirePressed();
            if (!isFirePressed) 
                return;
            foreach (var entity in _shooters.GetEntities())
            {
                if (!entity.isShootRequest)
                    entity.isShootRequest = true;
            }

        }
    }
}