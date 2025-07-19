using Game.Systems.ReactiveSystems;
using Reflex.Core;
using Reflex.Injectors;

namespace Game.Systems.Features
{
    public class ViewSystems : BaseFeature
    {
        public ViewSystems(Contexts contexts, Container injectContainer) : base("View Systems")
        {
            var addViewSystem = new AddViewSystem(contexts);
            AttributeInjector.Inject(addViewSystem, injectContainer);
            
            
            Add(addViewSystem);
            Add(new RenderPositionSystem(contexts));
            Add(new RenderDirectionSystem(contexts));
        }
    }
}