/**
* Code generation. Don't modify! 
**/

using UnityEngine;
using Atomic.Entities;
using System.Runtime.CompilerServices;
using Atomic.Elements;

namespace Atomic.Entities
{
    public static class MovementAPI
    {
        ///Keys
        public const int RootTransform = 1; // Transform
        public const int MovementSpeed = 2; // ReactiveVariable<float>
        public const int MovementDirection = 3; // ReactiveVariable<Vector3>


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
        public static ReactiveVariable<float> GetMovementSpeed(this IEntity obj) => obj.GetValue<ReactiveVariable<float>>(MovementSpeed);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetMovementSpeed(this IEntity obj, out ReactiveVariable<float> value) => obj.TryGetValue(MovementSpeed, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddMovementSpeed(this IEntity obj, ReactiveVariable<float> value) => obj.AddValue(MovementSpeed, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasMovementSpeed(this IEntity obj) => obj.HasValue(MovementSpeed);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelMovementSpeed(this IEntity obj) => obj.DelValue(MovementSpeed);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetMovementSpeed(this IEntity obj, ReactiveVariable<float> value) => obj.SetValue(MovementSpeed, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<Vector3> GetMovementDirection(this IEntity obj) => obj.GetValue<ReactiveVariable<Vector3>>(MovementDirection);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetMovementDirection(this IEntity obj, out ReactiveVariable<Vector3> value) => obj.TryGetValue(MovementDirection, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddMovementDirection(this IEntity obj, ReactiveVariable<Vector3> value) => obj.AddValue(MovementDirection, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasMovementDirection(this IEntity obj) => obj.HasValue(MovementDirection);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelMovementDirection(this IEntity obj) => obj.DelValue(MovementDirection);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetMovementDirection(this IEntity obj, ReactiveVariable<Vector3> value) => obj.SetValue(MovementDirection, value);
    }
}
