using Entitas;
using Game.Core;
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

[Game, Events]
public sealed class PositionComponent : IComponent
{
    public Vector3 Value;
}

[Game]
public sealed class MovableComponent : IComponent
{
}

[Game]
public sealed class KeyboardMovableComponent : IComponent
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

#region Fire
[Game]
public sealed class WeaponComponent : IComponent
{
    public Transform FirePoint;
    public Bullet BulletPrefab;
}

[Game]
public sealed class ShootRequest : IComponent
{
}

[Game]
public sealed class CanShoot : IComponent
{
    public bool Value;
}

[Game]
public sealed class CanShootFromKeyboard : IComponent
{
    
}
#endregion

[Events]
public sealed class SpawnRequest : IComponent
{
    
}

[Events]
public sealed class Prefab : IComponent
{
    public GameObject Value;
}