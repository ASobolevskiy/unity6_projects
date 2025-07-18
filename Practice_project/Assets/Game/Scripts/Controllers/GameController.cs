using Game.Systems;
using Game.Systems.Features;
using UnityEngine;
using ESystems = Entitas.Systems;

namespace Game.Controllers
{
    public class GameController : MonoBehaviour
    {
        [SerializeField]
        private GameObject _unit;

        private ESystems _systems;
        private void Start()
        {
            var contexts = Contexts.sharedInstance;
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
            return new Feature("Systems")
                .Add(new CreateEntitySystem(contexts))
                .Add(new MovementSystems(contexts))
                .Add(new ViewSystems(contexts, _unit));
        }
    }
}