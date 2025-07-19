using Game.Systems;
using Reflex.Core;
using Reflex.Extensions;
using Reflex.Injectors;
using UnityEngine;

namespace Game.Controllers
{
    public class GameController : MonoBehaviour
    {
        private Container _sceneScopeContainer;
        private Entitas.Systems _systems;
        
        private void Start()
        {
            var contexts = Contexts.sharedInstance;
            _sceneScopeContainer = gameObject.scene.GetSceneContainer();
            _systems = CreateSystems(contexts);
            _systems.Initialize();
        }

        private void Update()
        {
            _systems.Execute();
            _systems.Cleanup();
        }

        private Entitas.Systems CreateSystems(Contexts contexts)
        {
            var createBasesSystem = new CreateEntitiesForBasesSystem(contexts);
            AttributeInjector.Inject(createBasesSystem, _sceneScopeContainer);
            return new Feature("Systems")
                .Add(createBasesSystem)
                .Add(new HealthSystem(contexts.game))
                .Add(new RemoveDeadOrDestroyedEntitiesSystem(contexts.game));
        }
    }
}