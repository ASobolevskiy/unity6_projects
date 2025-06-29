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
        public const int IsShotDelaying = 9; // ReactiveVariable<bool>
        public const int BulletPrefab = 10; // SceneEntity
        public const int MaximumAmmo = 11; // ReactiveVariable<int>
        public const int AmmoReplenishTime = 12; // ReactiveVariable<float>
        public const int ShootRequest = 13; // IEvent
        public const int ShootAction = 14; // IEvent
        public const int ShootEvent = 15; // IEvent
        public const int IsAmmoReplenishing = 19; // ReactiveVariable<bool>
        public const int CurrentAmmo = 20; // ReactiveVariable<int>
        public const int DryShotEvent = 28; // IEvent
        public const int CanShoot = 29; // AndExpression
        public const int CanReplenishBullets = 33; // AndExpression


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
        public static ReactiveVariable<bool> GetIsShotDelaying(this IEntity obj) => obj.GetValue<ReactiveVariable<bool>>(IsShotDelaying);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetIsShotDelaying(this IEntity obj, out ReactiveVariable<bool> value) => obj.TryGetValue(IsShotDelaying, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddIsShotDelaying(this IEntity obj, ReactiveVariable<bool> value) => obj.AddValue(IsShotDelaying, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasIsShotDelaying(this IEntity obj) => obj.HasValue(IsShotDelaying);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelIsShotDelaying(this IEntity obj) => obj.DelValue(IsShotDelaying);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetIsShotDelaying(this IEntity obj, ReactiveVariable<bool> value) => obj.SetValue(IsShotDelaying, value);

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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<bool> GetIsAmmoReplenishing(this IEntity obj) => obj.GetValue<ReactiveVariable<bool>>(IsAmmoReplenishing);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetIsAmmoReplenishing(this IEntity obj, out ReactiveVariable<bool> value) => obj.TryGetValue(IsAmmoReplenishing, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddIsAmmoReplenishing(this IEntity obj, ReactiveVariable<bool> value) => obj.AddValue(IsAmmoReplenishing, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasIsAmmoReplenishing(this IEntity obj) => obj.HasValue(IsAmmoReplenishing);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelIsAmmoReplenishing(this IEntity obj) => obj.DelValue(IsAmmoReplenishing);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetIsAmmoReplenishing(this IEntity obj, ReactiveVariable<bool> value) => obj.SetValue(IsAmmoReplenishing, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<int> GetCurrentAmmo(this IEntity obj) => obj.GetValue<ReactiveVariable<int>>(CurrentAmmo);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetCurrentAmmo(this IEntity obj, out ReactiveVariable<int> value) => obj.TryGetValue(CurrentAmmo, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddCurrentAmmo(this IEntity obj, ReactiveVariable<int> value) => obj.AddValue(CurrentAmmo, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasCurrentAmmo(this IEntity obj) => obj.HasValue(CurrentAmmo);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelCurrentAmmo(this IEntity obj) => obj.DelValue(CurrentAmmo);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetCurrentAmmo(this IEntity obj, ReactiveVariable<int> value) => obj.SetValue(CurrentAmmo, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IEvent GetDryShotEvent(this IEntity obj) => obj.GetValue<IEvent>(DryShotEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetDryShotEvent(this IEntity obj, out IEvent value) => obj.TryGetValue(DryShotEvent, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddDryShotEvent(this IEntity obj, IEvent value) => obj.AddValue(DryShotEvent, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasDryShotEvent(this IEntity obj) => obj.HasValue(DryShotEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelDryShotEvent(this IEntity obj) => obj.DelValue(DryShotEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetDryShotEvent(this IEntity obj, IEvent value) => obj.SetValue(DryShotEvent, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AndExpression GetCanShoot(this IEntity obj) => obj.GetValue<AndExpression>(CanShoot);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetCanShoot(this IEntity obj, out AndExpression value) => obj.TryGetValue(CanShoot, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddCanShoot(this IEntity obj, AndExpression value) => obj.AddValue(CanShoot, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasCanShoot(this IEntity obj) => obj.HasValue(CanShoot);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelCanShoot(this IEntity obj) => obj.DelValue(CanShoot);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetCanShoot(this IEntity obj, AndExpression value) => obj.SetValue(CanShoot, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AndExpression GetCanReplenishBullets(this IEntity obj) => obj.GetValue<AndExpression>(CanReplenishBullets);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetCanReplenishBullets(this IEntity obj, out AndExpression value) => obj.TryGetValue(CanReplenishBullets, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddCanReplenishBullets(this IEntity obj, AndExpression value) => obj.AddValue(CanReplenishBullets, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasCanReplenishBullets(this IEntity obj) => obj.HasValue(CanReplenishBullets);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelCanReplenishBullets(this IEntity obj) => obj.DelValue(CanReplenishBullets);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetCanReplenishBullets(this IEntity obj, AndExpression value) => obj.SetValue(CanReplenishBullets, value);
    }
}
