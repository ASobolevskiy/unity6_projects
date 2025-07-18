using Entitas;

namespace Game.Systems.Features
{
    public abstract class BaseFeature : Feature
    {
        protected BaseFeature(Contexts contexts, string tag) : base(tag)
        {
        }
        public sealed override Entitas.Systems Add(ISystem system)
        {
            return base.Add(system);
        }
    }
}