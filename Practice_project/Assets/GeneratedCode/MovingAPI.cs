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
    public static class MovingAPI
    {
        ///Keys
        public const int RootTransform = 1; // Transform
        public const int MoveSpeed = 2; // ReactiveVariable<float>
        public const int MoveDirection = 3; // ReactiveVariable<Vector3>
        public const int IsMoving = 12; // ReactiveVariable<bool>


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Transform GetRootTransform(this IEntity obj) => obj.GetValue<Transform>(RootTransform);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetRootTransform(this IEntity obj, out Transform value) => obj.TryGetValue(RootTransform, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddRootTransform(this IEntity obj, Transform value) => obj.AddValue(RootTransform, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasRootTransform(this IEntity obj) => obj.HasValue(RootTransform);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelRootTransform(this IEntity obj) => obj.DelValue(RootTransform);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetRootTransform(this IEntity obj, Transform value) => obj.SetValue(RootTransform, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<float> GetMoveSpeed(this IEntity obj) => obj.GetValue<ReactiveVariable<float>>(MoveSpeed);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetMoveSpeed(this IEntity obj, out ReactiveVariable<float> value) => obj.TryGetValue(MoveSpeed, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddMoveSpeed(this IEntity obj, ReactiveVariable<float> value) => obj.AddValue(MoveSpeed, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasMoveSpeed(this IEntity obj) => obj.HasValue(MoveSpeed);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelMoveSpeed(this IEntity obj) => obj.DelValue(MoveSpeed);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetMoveSpeed(this IEntity obj, ReactiveVariable<float> value) => obj.SetValue(MoveSpeed, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<Vector3> GetMoveDirection(this IEntity obj) => obj.GetValue<ReactiveVariable<Vector3>>(MoveDirection);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetMoveDirection(this IEntity obj, out ReactiveVariable<Vector3> value) => obj.TryGetValue(MoveDirection, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddMoveDirection(this IEntity obj, ReactiveVariable<Vector3> value) => obj.AddValue(MoveDirection, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasMoveDirection(this IEntity obj) => obj.HasValue(MoveDirection);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelMoveDirection(this IEntity obj) => obj.DelValue(MoveDirection);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetMoveDirection(this IEntity obj, ReactiveVariable<Vector3> value) => obj.SetValue(MoveDirection, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<bool> GetIsMoving(this IEntity obj) => obj.GetValue<ReactiveVariable<bool>>(IsMoving);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetIsMoving(this IEntity obj, out ReactiveVariable<bool> value) => obj.TryGetValue(IsMoving, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddIsMoving(this IEntity obj, ReactiveVariable<bool> value) => obj.AddValue(IsMoving, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasIsMoving(this IEntity obj) => obj.HasValue(IsMoving);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelIsMoving(this IEntity obj) => obj.DelValue(IsMoving);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetIsMoving(this IEntity obj, ReactiveVariable<bool> value) => obj.SetValue(IsMoving, value);
    }
}
