namespace Game.Systems.Features
{
    public class ShootSystems : BaseFeature
    {
        public ShootSystems(Contexts contexts) : base("Shoot systems")
        {
            Add(new ShootFromKeyboardSystem(contexts));
            Add(new FireRequestSystem(contexts));
        }
    }
}