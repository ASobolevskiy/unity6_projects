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
    public static class HealthAPI
    {
        ///Keys
        public const int Hitpoints = 21; // ReactiveVariable<int>
        public const int IsDead = 22; // ReactiveVariable<bool>
        public const int TakeDamageAction = 23; // BaseEvent<int>


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<int> GetHitpoints(this IEntity obj) => obj.GetValue<ReactiveVariable<int>>(Hitpoints);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetHitpoints(this IEntity obj, out ReactiveVariable<int> value) => obj.TryGetValue(Hitpoints, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddHitpoints(this IEntity obj, ReactiveVariable<int> value) => obj.AddValue(Hitpoints, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasHitpoints(this IEntity obj) => obj.HasValue(Hitpoints);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelHitpoints(this IEntity obj) => obj.DelValue(Hitpoints);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetHitpoints(this IEntity obj, ReactiveVariable<int> value) => obj.SetValue(Hitpoints, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<bool> GetIsDead(this IEntity obj) => obj.GetValue<ReactiveVariable<bool>>(IsDead);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetIsDead(this IEntity obj, out ReactiveVariable<bool> value) => obj.TryGetValue(IsDead, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddIsDead(this IEntity obj, ReactiveVariable<bool> value) => obj.AddValue(IsDead, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasIsDead(this IEntity obj) => obj.HasValue(IsDead);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelIsDead(this IEntity obj) => obj.DelValue(IsDead);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetIsDead(this IEntity obj, ReactiveVariable<bool> value) => obj.SetValue(IsDead, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static BaseEvent<int> GetTakeDamageAction(this IEntity obj) => obj.GetValue<BaseEvent<int>>(TakeDamageAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetTakeDamageAction(this IEntity obj, out BaseEvent<int> value) => obj.TryGetValue(TakeDamageAction, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddTakeDamageAction(this IEntity obj, BaseEvent<int> value) => obj.AddValue(TakeDamageAction, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasTakeDamageAction(this IEntity obj) => obj.HasValue(TakeDamageAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelTakeDamageAction(this IEntity obj) => obj.DelValue(TakeDamageAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetTakeDamageAction(this IEntity obj, BaseEvent<int> value) => obj.SetValue(TakeDamageAction, value);
    }
}
