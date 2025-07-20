using Entitas;
using Game.Scripts.Core;

[Events]
public sealed class UnitPrefabComponent : IComponent
{
    public Unit Value;
}

[Events]
public sealed class SpawnRequested : IComponent
{
}

