using Entitas;
using Game.Configs;
using Reflex.Attributes;

namespace Game.Systems
{
    public class CreateEntitiesForBasesSystem : IInitializeSystem
    {
        private readonly BaseEntityFactory _factory;

        [Inject]
        private RedBaseConfig _redBaseConfig;

        [Inject]
        private BlueBaseConfig _blueBaseConfig;

        public CreateEntitiesForBasesSystem(Contexts contexts)
        {
            _factory = new BaseEntityFactory(contexts.game);
        }

        public void Initialize()
        {
            _factory.ConstructEntity(_redBaseConfig);
            _factory.ConstructEntity(_blueBaseConfig);
        }
    }

    public class BaseEntityFactory
    {
        private readonly GameContext _context;
        
        public BaseEntityFactory(GameContext context)
        {
            _context = context;
        }

        public GameEntity ConstructEntity(BaseConfig config)
        {
            var entity = _context.CreateEntity();
            entity.AddHealth(config.HitPoints);
            return entity;
        }
    }
}