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
    public static class RotationAPI
    {
        ///Keys
        public const int Rotation = 30; // ReactiveVariable<Quaternion>
        public const int CanRotate = 31; // AndExpression


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<Quaternion> GetRotation(this IEntity obj) => obj.GetValue<ReactiveVariable<Quaternion>>(Rotation);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetRotation(this IEntity obj, out ReactiveVariable<Quaternion> value) => obj.TryGetValue(Rotation, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddRotation(this IEntity obj, ReactiveVariable<Quaternion> value) => obj.AddValue(Rotation, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasRotation(this IEntity obj) => obj.HasValue(Rotation);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelRotation(this IEntity obj) => obj.DelValue(Rotation);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetRotation(this IEntity obj, ReactiveVariable<Quaternion> value) => obj.SetValue(Rotation, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AndExpression GetCanRotate(this IEntity obj) => obj.GetValue<AndExpression>(CanRotate);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetCanRotate(this IEntity obj, out AndExpression value) => obj.TryGetValue(CanRotate, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddCanRotate(this IEntity obj, AndExpression value) => obj.AddValue(CanRotate, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasCanRotate(this IEntity obj) => obj.HasValue(CanRotate);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelCanRotate(this IEntity obj) => obj.DelValue(CanRotate);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetCanRotate(this IEntity obj, AndExpression value) => obj.SetValue(CanRotate, value);
    }
}
