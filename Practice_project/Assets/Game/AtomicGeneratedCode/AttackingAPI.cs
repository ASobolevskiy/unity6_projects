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
    public static class AttackingAPI
    {
        ///Keys
        public const int AttackRequest = 39; // IEvent
        public const int CanAttack = 40; // AndExpression
        public const int AttackCooldown = 41; // ReactiveVariable<float>
        public const int Damage = 42; // ReactiveVariable<int>
        public const int IsAttackDelaying = 43; // ReactiveVariable<bool>
        public const int IsInAttackRange = 44; // ReactiveVariable<bool>


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IEvent GetAttackRequest(this IEntity obj) => obj.GetValue<IEvent>(AttackRequest);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetAttackRequest(this IEntity obj, out IEvent value) => obj.TryGetValue(AttackRequest, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddAttackRequest(this IEntity obj, IEvent value) => obj.AddValue(AttackRequest, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasAttackRequest(this IEntity obj) => obj.HasValue(AttackRequest);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelAttackRequest(this IEntity obj) => obj.DelValue(AttackRequest);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetAttackRequest(this IEntity obj, IEvent value) => obj.SetValue(AttackRequest, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AndExpression GetCanAttack(this IEntity obj) => obj.GetValue<AndExpression>(CanAttack);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetCanAttack(this IEntity obj, out AndExpression value) => obj.TryGetValue(CanAttack, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddCanAttack(this IEntity obj, AndExpression value) => obj.AddValue(CanAttack, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasCanAttack(this IEntity obj) => obj.HasValue(CanAttack);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelCanAttack(this IEntity obj) => obj.DelValue(CanAttack);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetCanAttack(this IEntity obj, AndExpression value) => obj.SetValue(CanAttack, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<float> GetAttackCooldown(this IEntity obj) => obj.GetValue<ReactiveVariable<float>>(AttackCooldown);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetAttackCooldown(this IEntity obj, out ReactiveVariable<float> value) => obj.TryGetValue(AttackCooldown, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddAttackCooldown(this IEntity obj, ReactiveVariable<float> value) => obj.AddValue(AttackCooldown, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasAttackCooldown(this IEntity obj) => obj.HasValue(AttackCooldown);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelAttackCooldown(this IEntity obj) => obj.DelValue(AttackCooldown);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetAttackCooldown(this IEntity obj, ReactiveVariable<float> value) => obj.SetValue(AttackCooldown, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<int> GetDamage(this IEntity obj) => obj.GetValue<ReactiveVariable<int>>(Damage);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetDamage(this IEntity obj, out ReactiveVariable<int> value) => obj.TryGetValue(Damage, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddDamage(this IEntity obj, ReactiveVariable<int> value) => obj.AddValue(Damage, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasDamage(this IEntity obj) => obj.HasValue(Damage);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelDamage(this IEntity obj) => obj.DelValue(Damage);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetDamage(this IEntity obj, ReactiveVariable<int> value) => obj.SetValue(Damage, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<bool> GetIsAttackDelaying(this IEntity obj) => obj.GetValue<ReactiveVariable<bool>>(IsAttackDelaying);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetIsAttackDelaying(this IEntity obj, out ReactiveVariable<bool> value) => obj.TryGetValue(IsAttackDelaying, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddIsAttackDelaying(this IEntity obj, ReactiveVariable<bool> value) => obj.AddValue(IsAttackDelaying, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasIsAttackDelaying(this IEntity obj) => obj.HasValue(IsAttackDelaying);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelIsAttackDelaying(this IEntity obj) => obj.DelValue(IsAttackDelaying);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetIsAttackDelaying(this IEntity obj, ReactiveVariable<bool> value) => obj.SetValue(IsAttackDelaying, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<bool> GetIsInAttackRange(this IEntity obj) => obj.GetValue<ReactiveVariable<bool>>(IsInAttackRange);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetIsInAttackRange(this IEntity obj, out ReactiveVariable<bool> value) => obj.TryGetValue(IsInAttackRange, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddIsInAttackRange(this IEntity obj, ReactiveVariable<bool> value) => obj.AddValue(IsInAttackRange, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasIsInAttackRange(this IEntity obj) => obj.HasValue(IsInAttackRange);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelIsInAttackRange(this IEntity obj) => obj.DelValue(IsInAttackRange);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetIsInAttackRange(this IEntity obj, ReactiveVariable<bool> value) => obj.SetValue(IsInAttackRange, value);
    }
}
