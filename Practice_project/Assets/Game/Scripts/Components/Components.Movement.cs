using Entitas;
using UnityEngine;

public sealed class MovableComponent : IComponent
{
}

public sealed class MoveSpeedComponent : IComponent
{
    public float Value;
}

[Game, Events]
public sealed class MovementDirectionComponent : IComponent
{
    public Vector3 Value;
}