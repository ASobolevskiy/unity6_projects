using System.Collections.Generic;
using Entitas;
using Entitas.Unity;
using Game.Scripts.Core;
using Game.Scripts.Utils;
using Reflex.Attributes;

namespace Game.Systems
{
    public class CreateEntitiesForBasesSystem : IInitializeSystem
    {
        private readonly BaseEntityFactory _factory;

        [Inject]
        private List<BaseBuilding> _baseBuildings;

        public CreateEntitiesForBasesSystem(Contexts contexts)
        {
            _factory = new BaseEntityFactory(contexts.game);
        }

        public void Initialize()
        {
            foreach (var baseBuilding in _baseBuildings)
            {
                _factory.ConstructEntity(baseBuilding);
            }
        }
    }

    public class BaseEntityFactory
    {
        private readonly GameContext _context;
        
        public BaseEntityFactory(GameContext context)
        {
            _context = context;
        }

        public void ConstructEntity(BaseBuilding baseBuilding)
        {
            var entity = _context.CreateEntity();
            entity.AddHealth(baseBuilding.GetHitPoints());
            if (baseBuilding.GetTeam() == TeamEnum.Blue)
                entity.isBlueTeam = true;
            else
                entity.isRedTeam = true;
            entity.isBuildingBase = true;
            entity.isMovable = false;
            
            var go = baseBuilding.gameObject;
            entity.AddSceneView(go);
            go.Link(entity);
        }
    }
}