using Entitas;
using Game.Scripts.Core;

[Events]
public sealed class UnitPrefabComponent : IComponent
{
    public Unit Value;
}

[Events]
public sealed class UnitSpawnRequested : IComponent
{
}

[Events]
public sealed class ProjectilePrefabComponent : IComponent
{
    public Projectile Value;
}

[Events]
public sealed class ProjectileSpawnRequested : IComponent
{
}

