using Entitas;

public sealed class TargetComponent : IComponent
{
    public GameEntity Value;
}

public sealed class AttackingComponent : IComponent
{
}

public sealed class AttackRangeComponent : IComponent
{
    public float Value;
}