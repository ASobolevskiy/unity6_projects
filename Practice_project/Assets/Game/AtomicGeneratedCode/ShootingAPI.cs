/**
* Code generation. Don't modify! 
**/

using UnityEngine;
using Atomic.Entities;
using System.Runtime.CompilerServices;
using Atomic.Elements;
using Game.Utils;

namespace Atomic.Entities
{
    public static class ShootingAPI
    {
        ///Keys
        public const int FirePointTransform = 7; // Transform
        public const int ShootDelayTime = 8; // ReactiveVariable<float>
        public const int IsReloading = 9; // ReactiveVariable<bool>
        public const int BulletPrefab = 10; // SceneEntity
        public const int MaximumAmmo = 11; // ReactiveVariable<int>
        public const int AmmoReplenishTime = 12; // ReactiveVariable<float>
        public const int ShootRequest = 13; // IEvent
        public const int ShootAction = 14; // IEvent
        public const int ShootEvent = 15; // IEvent


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Transform GetFirePointTransform(this IEntity obj) => obj.GetValue<Transform>(FirePointTransform);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetFirePointTransform(this IEntity obj, out Transform value) => obj.TryGetValue(FirePointTransform, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddFirePointTransform(this IEntity obj, Transform value) => obj.AddValue(FirePointTransform, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasFirePointTransform(this IEntity obj) => obj.HasValue(FirePointTransform);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelFirePointTransform(this IEntity obj) => obj.DelValue(FirePointTransform);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetFirePointTransform(this IEntity obj, Transform value) => obj.SetValue(FirePointTransform, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<float> GetShootDelayTime(this IEntity obj) => obj.GetValue<ReactiveVariable<float>>(ShootDelayTime);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetShootDelayTime(this IEntity obj, out ReactiveVariable<float> value) => obj.TryGetValue(ShootDelayTime, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddShootDelayTime(this IEntity obj, ReactiveVariable<float> value) => obj.AddValue(ShootDelayTime, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasShootDelayTime(this IEntity obj) => obj.HasValue(ShootDelayTime);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelShootDelayTime(this IEntity obj) => obj.DelValue(ShootDelayTime);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetShootDelayTime(this IEntity obj, ReactiveVariable<float> value) => obj.SetValue(ShootDelayTime, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<bool> GetIsReloading(this IEntity obj) => obj.GetValue<ReactiveVariable<bool>>(IsReloading);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetIsReloading(this IEntity obj, out ReactiveVariable<bool> value) => obj.TryGetValue(IsReloading, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddIsReloading(this IEntity obj, ReactiveVariable<bool> value) => obj.AddValue(IsReloading, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasIsReloading(this IEntity obj) => obj.HasValue(IsReloading);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelIsReloading(this IEntity obj) => obj.DelValue(IsReloading);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetIsReloading(this IEntity obj, ReactiveVariable<bool> value) => obj.SetValue(IsReloading, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SceneEntity GetBulletPrefab(this IEntity obj) => obj.GetValue<SceneEntity>(BulletPrefab);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetBulletPrefab(this IEntity obj, out SceneEntity value) => obj.TryGetValue(BulletPrefab, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddBulletPrefab(this IEntity obj, SceneEntity value) => obj.AddValue(BulletPrefab, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasBulletPrefab(this IEntity obj) => obj.HasValue(BulletPrefab);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelBulletPrefab(this IEntity obj) => obj.DelValue(BulletPrefab);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetBulletPrefab(this IEntity obj, SceneEntity value) => obj.SetValue(BulletPrefab, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<int> GetMaximumAmmo(this IEntity obj) => obj.GetValue<ReactiveVariable<int>>(MaximumAmmo);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetMaximumAmmo(this IEntity obj, out ReactiveVariable<int> value) => obj.TryGetValue(MaximumAmmo, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddMaximumAmmo(this IEntity obj, ReactiveVariable<int> value) => obj.AddValue(MaximumAmmo, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasMaximumAmmo(this IEntity obj) => obj.HasValue(MaximumAmmo);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelMaximumAmmo(this IEntity obj) => obj.DelValue(MaximumAmmo);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetMaximumAmmo(this IEntity obj, ReactiveVariable<int> value) => obj.SetValue(MaximumAmmo, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<float> GetAmmoReplenishTime(this IEntity obj) => obj.GetValue<ReactiveVariable<float>>(AmmoReplenishTime);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetAmmoReplenishTime(this IEntity obj, out ReactiveVariable<float> value) => obj.TryGetValue(AmmoReplenishTime, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddAmmoReplenishTime(this IEntity obj, ReactiveVariable<float> value) => obj.AddValue(AmmoReplenishTime, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasAmmoReplenishTime(this IEntity obj) => obj.HasValue(AmmoReplenishTime);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelAmmoReplenishTime(this IEntity obj) => obj.DelValue(AmmoReplenishTime);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetAmmoReplenishTime(this IEntity obj, ReactiveVariable<float> value) => obj.SetValue(AmmoReplenishTime, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IEvent GetShootRequest(this IEntity obj) => obj.GetValue<IEvent>(ShootRequest);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetShootRequest(this IEntity obj, out IEvent value) => obj.TryGetValue(ShootRequest, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddShootRequest(this IEntity obj, IEvent value) => obj.AddValue(ShootRequest, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasShootRequest(this IEntity obj) => obj.HasValue(ShootRequest);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelShootRequest(this IEntity obj) => obj.DelValue(ShootRequest);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetShootRequest(this IEntity obj, IEvent value) => obj.SetValue(ShootRequest, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IEvent GetShootAction(this IEntity obj) => obj.GetValue<IEvent>(ShootAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetShootAction(this IEntity obj, out IEvent value) => obj.TryGetValue(ShootAction, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddShootAction(this IEntity obj, IEvent value) => obj.AddValue(ShootAction, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasShootAction(this IEntity obj) => obj.HasValue(ShootAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelShootAction(this IEntity obj) => obj.DelValue(ShootAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetShootAction(this IEntity obj, IEvent value) => obj.SetValue(ShootAction, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IEvent GetShootEvent(this IEntity obj) => obj.GetValue<IEvent>(ShootEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetShootEvent(this IEntity obj, out IEvent value) => obj.TryGetValue(ShootEvent, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddShootEvent(this IEntity obj, IEvent value) => obj.AddValue(ShootEvent, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasShootEvent(this IEntity obj) => obj.HasValue(ShootEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelShootEvent(this IEntity obj) => obj.DelValue(ShootEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetShootEvent(this IEntity obj, IEvent value) => obj.SetValue(ShootEvent, value);
    }
}
