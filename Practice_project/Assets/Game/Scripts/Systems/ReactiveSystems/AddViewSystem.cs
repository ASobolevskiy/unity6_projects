using System.Collections.Generic;
using Entitas;
using Entitas.Unity;
using UnityEngine;

namespace Game.Systems.ReactiveSystems
{
    public sealed class AddViewSystem : ReactiveSystem<GameEntity>
    {
        private readonly Transform _viewContainer = new GameObject("Game Views").transform;
        private readonly GameContext _context;
        private GameObject _go;
        
        public AddViewSystem(Contexts contexts, GameObject go = null) : base(contexts.game)
        {
            _context = contexts.game;
            _go = go;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.Unit);
        }

        protected override bool Filter(GameEntity entity)
        {
            return entity.isUnit && !entity.hasSceneView;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            foreach (var entity in entities)
            {
                if (_go == null)
                {
                    _go = new GameObject("Game View");
                    _go.transform.SetParent(_viewContainer, false);
                }
                entity.AddSceneView(_go);
                _go.Link(entity);
            }
        }
    }
}