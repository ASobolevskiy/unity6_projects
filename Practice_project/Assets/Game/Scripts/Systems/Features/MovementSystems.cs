namespace Game.Systems.Features
{
    public class MovementSystems : BaseFeature
    {
        public MovementSystems(Contexts contexts) : base("Movement Systems")
        {
            Add(new MoveSystem(contexts));
            Add(new MoveFromKeyboardSystem(contexts));
        }
    }
}