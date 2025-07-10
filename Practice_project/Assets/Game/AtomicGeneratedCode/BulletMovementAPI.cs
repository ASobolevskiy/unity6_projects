/**
* Code generation. Don't modify! 
**/

using UnityEngine;
using Atomic.Entities;
using System.Runtime.CompilerServices;
using Atomic.Elements;
using Game.Utils;
using Game.Core.Trigger;

namespace Atomic.Entities
{
    public static class BulletMovementAPI
    {
        ///Keys
        public const int BulletSpeed = 16; // ReactiveVariable<float>
        public const int BulletTransform = 17; // Transform
        public const int BulletDirection = 18; // ReactiveVariable<Vector3>


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<float> GetBulletSpeed(this IEntity obj) => obj.GetValue<ReactiveVariable<float>>(BulletSpeed);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetBulletSpeed(this IEntity obj, out ReactiveVariable<float> value) => obj.TryGetValue(BulletSpeed, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddBulletSpeed(this IEntity obj, ReactiveVariable<float> value) => obj.AddValue(BulletSpeed, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasBulletSpeed(this IEntity obj) => obj.HasValue(BulletSpeed);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelBulletSpeed(this IEntity obj) => obj.DelValue(BulletSpeed);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetBulletSpeed(this IEntity obj, ReactiveVariable<float> value) => obj.SetValue(BulletSpeed, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Transform GetBulletTransform(this IEntity obj) => obj.GetValue<Transform>(BulletTransform);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetBulletTransform(this IEntity obj, out Transform value) => obj.TryGetValue(BulletTransform, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddBulletTransform(this IEntity obj, Transform value) => obj.AddValue(BulletTransform, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasBulletTransform(this IEntity obj) => obj.HasValue(BulletTransform);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelBulletTransform(this IEntity obj) => obj.DelValue(BulletTransform);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetBulletTransform(this IEntity obj, Transform value) => obj.SetValue(BulletTransform, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<Vector3> GetBulletDirection(this IEntity obj) => obj.GetValue<ReactiveVariable<Vector3>>(BulletDirection);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetBulletDirection(this IEntity obj, out ReactiveVariable<Vector3> value) => obj.TryGetValue(BulletDirection, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddBulletDirection(this IEntity obj, ReactiveVariable<Vector3> value) => obj.AddValue(BulletDirection, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasBulletDirection(this IEntity obj) => obj.HasValue(BulletDirection);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelBulletDirection(this IEntity obj) => obj.DelValue(BulletDirection);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetBulletDirection(this IEntity obj, ReactiveVariable<Vector3> value) => obj.SetValue(BulletDirection, value);
    }
}
