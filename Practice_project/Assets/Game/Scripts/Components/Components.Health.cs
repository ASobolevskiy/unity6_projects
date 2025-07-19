using Entitas;

[Game]
public sealed class HealthComponent : IComponent
{
    public int Value;
}

public sealed class DeadOrDestroyedComponent : IComponent
{
}
