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
    public static class MovementAPI
    {
        ///Keys
        public const int RootTransform = 1; // Transform
        public const int MovementSpeed = 2; // ReactiveVariable<float>
        public const int MovementDirection = 3; // ReactiveVariable<Vector3>
        public const int IsMoving = 4; // ReactiveVariable<bool>
        public const int CanMove = 32; // AndExpression


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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AndExpression GetCanMove(this IEntity obj) => obj.GetValue<AndExpression>(CanMove);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetCanMove(this IEntity obj, out AndExpression value) => obj.TryGetValue(CanMove, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddCanMove(this IEntity obj, AndExpression value) => obj.AddValue(CanMove, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasCanMove(this IEntity obj) => obj.HasValue(CanMove);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelCanMove(this IEntity obj) => obj.DelValue(CanMove);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetCanMove(this IEntity obj, AndExpression value) => obj.SetValue(CanMove, value);
    }
}
