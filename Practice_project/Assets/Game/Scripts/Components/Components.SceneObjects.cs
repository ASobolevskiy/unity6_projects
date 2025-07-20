using Entitas;
using UnityEngine;

[Game, Events]
public sealed class RedTeamComponent : IComponent
{
}

[Game, Events]
public sealed class BlueTeamComponent : IComponent
{
}

public sealed class BuildingBaseComponent : IComponent
{
}

[Game,Events]
public sealed class UnitComponent : IComponent
{
}

[Game, Events]
public sealed class ProjectileComponent : IComponent
{
}

public sealed class SceneViewComponent : IComponent
{
    public GameObject Value;
}

[Game, Events]
public sealed class PositionComponent : IComponent
{
    public Vector3 Value;
}

[Game, Events]
public sealed class RotationComponent : IComponent
{
    public Quaternion Value;
}
