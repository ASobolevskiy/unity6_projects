/**
* Code generation. Don't modify! 
**/

using UnityEngine;
using Atomic.Entities;
using System.Runtime.CompilerServices;
using Atomic.Elements;
using AtomicPlayground;
using AtomicPlayground.Utils;

namespace Atomic.Entities
{
    public static class ShootingAPI
    {
        ///Keys
        public const int ReloadTime = 7; // ReactiveVariable<float>
        public const int IsReloading = 8; // ReactiveVariable<bool>
        public const int BulletPrefab = 9; // Bullet
        public const int FirePointTransform = 10; // Transform
        public const int ShootAction = 11; // BaseEvent
        public const int ShootRequest = 14; // IEvent
        public const int ShootEvent = 15; // IEvent


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<float> GetReloadTime(this IEntity obj) => obj.GetValue<ReactiveVariable<float>>(ReloadTime);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetReloadTime(this IEntity obj, out ReactiveVariable<float> value) => obj.TryGetValue(ReloadTime, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddReloadTime(this IEntity obj, ReactiveVariable<float> value) => obj.AddValue(ReloadTime, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasReloadTime(this IEntity obj) => obj.HasValue(ReloadTime);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelReloadTime(this IEntity obj) => obj.DelValue(ReloadTime);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetReloadTime(this IEntity obj, ReactiveVariable<float> value) => obj.SetValue(ReloadTime, value);

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
        public static Bullet GetBulletPrefab(this IEntity obj) => obj.GetValue<Bullet>(BulletPrefab);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetBulletPrefab(this IEntity obj, out Bullet value) => obj.TryGetValue(BulletPrefab, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddBulletPrefab(this IEntity obj, Bullet value) => obj.AddValue(BulletPrefab, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasBulletPrefab(this IEntity obj) => obj.HasValue(BulletPrefab);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelBulletPrefab(this IEntity obj) => obj.DelValue(BulletPrefab);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetBulletPrefab(this IEntity obj, Bullet value) => obj.SetValue(BulletPrefab, value);

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
        public static BaseEvent GetShootAction(this IEntity obj) => obj.GetValue<BaseEvent>(ShootAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetShootAction(this IEntity obj, out BaseEvent value) => obj.TryGetValue(ShootAction, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddShootAction(this IEntity obj, BaseEvent value) => obj.AddValue(ShootAction, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasShootAction(this IEntity obj) => obj.HasValue(ShootAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelShootAction(this IEntity obj) => obj.DelValue(ShootAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetShootAction(this IEntity obj, BaseEvent value) => obj.SetValue(ShootAction, value);

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
