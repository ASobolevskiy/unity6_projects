using System.Collections.Generic;
using Entitas;
using Entitas.Unity;
using Reflex.Attributes;
using UnityEngine;

namespace Game.Systems.ReactiveSystems
{
    public sealed class AddViewSystem : ReactiveSystem<GameEntity>
    {
        private readonly Transform _viewContainer = new GameObject("LectureExample_Entitas Views").transform;
        private readonly GameContext _context;
        
        [Inject]
        private GameObject _go;
         
        public AddViewSystem(Contexts contexts) : base(contexts.game)
        {
            _context = contexts.game;
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
                    _go = new GameObject("LectureExample_Entitas View");
                    _go.transform.SetParent(_viewContainer, false);
                }
                entity.AddSceneView(_go);
                entity.ReplacePosition(_go.transform.position);
                _go.Link(entity);
            }
        }
    }
}