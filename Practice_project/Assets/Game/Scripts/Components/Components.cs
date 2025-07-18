using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

#region Movement

[Game]
public sealed class MoveSpeedComponent : IComponent
{
    public float Value;
}

[Game]
public sealed class MoveDirectionComponent : IComponent
{
    public Vector3 Value;
}

[Game]
public sealed class PositionComponent : IComponent
{
    public Vector3 Value;
}

public sealed class MovableComponent : IComponent
{
}

#endregion

[Game]
public sealed class UnitComponent : IComponent
{
}

[Game]
public sealed class SceneViewComponent : IComponent
{
    public GameObject Value;
}