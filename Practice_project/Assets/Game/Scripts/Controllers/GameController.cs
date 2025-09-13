using Entitas;
using Game.Scripts.Systems.ExecuteSystems;
using Game.Scripts.Utils;
using Game.Systems;
using Reflex.Core;
using Reflex.Extensions;
using Reflex.Injectors;
using UnityEngine;

namespace Game.Controllers
{
    public class GameController : MonoBehaviour
    {
        private Contexts _contexts;
        private Container _sceneScopeContainer;
        private Entitas.Systems _gameSystems;
        private Entitas.Systems _eventSystems;
        private bool _isGameOver;
        
        private void Start()
        {
            _contexts = Contexts.sharedInstance;
            _sceneScopeContainer = gameObject.scene.GetSceneContainer();
            
            _gameSystems = CreateGameSystems(_contexts);
            _eventSystems = CreateEventSystems(_contexts);
            
            _gameSystems.Initialize();
            _eventSystems.Initialize();
            
            _contexts.game.OnEntityWillBeDestroyed += HandleEntityWillBeDestroyed;
        }

        private void Update()
        {
            if (_isGameOver) 
                return;
            
            _gameSystems.Execute();
            _gameSystems.Cleanup();
            
            _eventSystems.Execute();
            _eventSystems.Cleanup();
        }

        private void OnDestroy()
        {
            _contexts.game.OnEntityWillBeDestroyed -= HandleEntityWillBeDestroyed;
        }

        private Entitas.Systems CreateGameSystems(Contexts contexts)
        {
            var createBasesSystem = new CreateEntitiesForBasesSystem(contexts);
            AttributeInjector.Inject(createBasesSystem, _sceneScopeContainer);
            
            return new Feature("Game systems")
                .Add(createBasesSystem)
                .Add(new MovementSystem(contexts))
                .Add(new LinkEntityPositionToGameObjectPositionSystem(contexts))
                .Add(new HealthSystem(contexts.game))
                .Add(new TargetLookUpSystem(contexts))
                .Add(new AttackIfTargetInRangeSystem(contexts))
                .Add(new RemoveDeadOrDestroyedEntitiesSystem(contexts.game));
        }

        private Entitas.Systems CreateEventSystems(Contexts contexts)
        {
            var unitSpawnSystem = new UnitSpawnSystem(contexts);
            AttributeInjector.Inject(unitSpawnSystem, _sceneScopeContainer);
            return new Feature("Event systems")
                .Add(unitSpawnSystem)
                .Add(new ProjectileSpawnSystem(contexts));
        }
        
        private void HandleEntityWillBeDestroyed(IContext context, IEntity entity)
        {
            if (entity is not GameEntity { isBuildingBase: true } gameEntity)
                return;
            
            _gameSystems.DeactivateReactiveSystems();
            _eventSystems.DeactivateReactiveSystems();
            
            _isGameOver = true;
            var winnerTeam = gameEntity.isBlueTeam 
                ? TeamEnum.Red 
                : TeamEnum.Blue;
            
            //TODO Show game over popup
        }
    }
}