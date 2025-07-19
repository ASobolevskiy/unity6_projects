using Entitas;

namespace Game.Systems
{
    public class FireRequestSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _fireRequestors;
        private readonly Contexts _contexts;
        
        public FireRequestSystem(Contexts contexts)
        {
            _contexts = contexts;
            var matches = new[]
            {
                GameMatcher.Weapon,
                GameMatcher.ShootRequest
            };

            _fireRequestors = contexts.game.GetGroup(GameMatcher.AllOf(matches));
        }

        public void Execute()
        {
            foreach (var entity in _fireRequestors.GetEntities())
            {
                var weapon = entity.weapon;
                var eventEntity = _contexts.events.CreateEntity();
                eventEntity.isSpawnRequest = true;
                eventEntity.AddPosition(weapon.FirePoint.position);
                eventEntity.AddPrefab(weapon.BulletPrefab.gameObject);
                entity.isShootRequest = false;
            }
        }
    }
}