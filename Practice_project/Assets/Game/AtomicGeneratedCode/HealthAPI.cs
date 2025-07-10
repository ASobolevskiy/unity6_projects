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
    public static class HealthAPI
    {
        ///Keys
        public const int Hitpoints = 21; // ReactiveVariable<int>
        public const int IsDead = 22; // ReactiveVariable<bool>
        public const int TakeDamageAction = 23; // BaseEvent<int>
        public const int TakeDamageEvent = 34; // IEvent
        public const int EnemyDeadEvent = 54; // IEvent


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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IEvent GetTakeDamageEvent(this IEntity obj) => obj.GetValue<IEvent>(TakeDamageEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetTakeDamageEvent(this IEntity obj, out IEvent value) => obj.TryGetValue(TakeDamageEvent, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddTakeDamageEvent(this IEntity obj, IEvent value) => obj.AddValue(TakeDamageEvent, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasTakeDamageEvent(this IEntity obj) => obj.HasValue(TakeDamageEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelTakeDamageEvent(this IEntity obj) => obj.DelValue(TakeDamageEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetTakeDamageEvent(this IEntity obj, IEvent value) => obj.SetValue(TakeDamageEvent, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IEvent GetEnemyDeadEvent(this IEntity obj) => obj.GetValue<IEvent>(EnemyDeadEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetEnemyDeadEvent(this IEntity obj, out IEvent value) => obj.TryGetValue(EnemyDeadEvent, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddEnemyDeadEvent(this IEntity obj, IEvent value) => obj.AddValue(EnemyDeadEvent, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasEnemyDeadEvent(this IEntity obj) => obj.HasValue(EnemyDeadEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelEnemyDeadEvent(this IEntity obj) => obj.DelValue(EnemyDeadEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetEnemyDeadEvent(this IEntity obj, IEvent value) => obj.SetValue(EnemyDeadEvent, value);
    }
}
