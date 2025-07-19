using System;
using Game.Systems;
using Game.Systems.Features;
using Reflex.Core;
using Reflex.Extensions;
using Reflex.Injectors;
using UnityEngine;
using ESystems = Entitas.Systems;

namespace Game.Controllers
{
    public class GameController : MonoBehaviour
    {
        private ESystems _systems;
        private Container _container;
        
        private void Start()
        {
            _container = gameObject.scene.GetSceneContainer();
            var contexts = Contexts.sharedInstance;
            var extraInstallingScope = new ExtraInstallerScope(builder =>
            {
                builder.AddSingleton(contexts);
            });
            _systems = CreateSystems(contexts);
            _systems.Initialize();
        }

        private void Update()
        {
            _systems.Execute();
            _systems.Cleanup();
        }

        private ESystems CreateSystems(Contexts contexts)
        {
            var createEntitySystem = new CreateEntitySystem(contexts);
            AttributeInjector.Inject(createEntitySystem, _container);
            return new Feature("Systems")
                .Add(createEntitySystem)
                .Add(new MovementSystems(contexts))
                .Add(new ShootSystems(contexts))
                .Add(new SpawnRequestSystem(contexts))
                .Add(new ViewSystems(contexts, _container));
        }
    }
}