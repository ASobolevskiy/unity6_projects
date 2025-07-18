using Entitas;
using Game.Systems.ReactiveSystems;
using UnityEngine;

namespace Game.Systems.Features
{
    public class ViewSystems : BaseFeature
    {
        public ViewSystems(Contexts contexts, GameObject go = null) : base(contexts, "View Systems")
        {
            Add(new AddViewSystem(contexts, go));
            Add(new RenderPositionSystem(contexts));
        }
    }
}