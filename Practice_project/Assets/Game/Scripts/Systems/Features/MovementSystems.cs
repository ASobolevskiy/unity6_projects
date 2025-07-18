namespace Game.Systems.Features
{
    public class MovementSystems : BaseFeature
    {
        public MovementSystems(Contexts contexts) : base(contexts, "Movement Systems")
        {
            Add(new MoveSystem(contexts));
        }
    }
}