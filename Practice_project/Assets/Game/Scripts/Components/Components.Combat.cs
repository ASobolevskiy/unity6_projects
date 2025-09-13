using Entitas;
using Game.Scripts.Core;
using UnityEngine;

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

public sealed class WeaponComponent : IComponent
{
    public bool IsRanged;
    public Transform AttackPoint;
    public Projectile Prefab;
}