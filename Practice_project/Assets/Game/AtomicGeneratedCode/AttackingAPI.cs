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
        public const int AttackDistance = 45; // ReactiveVariable<float>
        public const int IsAttacking = 46; // ReactiveVariable<bool>
        public const int AttackPoint = 47; // ReactiveVariable<Transform>
        public const int HitEvent = 48; // IEvent
        public const int HitAction = 49; // IEvent
        public const int TargetLayer = 50; // ReactiveVariable<LayerMask>
        public const int AttackFinished = 52; // IEvent


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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<float> GetAttackDistance(this IEntity obj) => obj.GetValue<ReactiveVariable<float>>(AttackDistance);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetAttackDistance(this IEntity obj, out ReactiveVariable<float> value) => obj.TryGetValue(AttackDistance, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddAttackDistance(this IEntity obj, ReactiveVariable<float> value) => obj.AddValue(AttackDistance, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasAttackDistance(this IEntity obj) => obj.HasValue(AttackDistance);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelAttackDistance(this IEntity obj) => obj.DelValue(AttackDistance);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetAttackDistance(this IEntity obj, ReactiveVariable<float> value) => obj.SetValue(AttackDistance, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<bool> GetIsAttacking(this IEntity obj) => obj.GetValue<ReactiveVariable<bool>>(IsAttacking);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetIsAttacking(this IEntity obj, out ReactiveVariable<bool> value) => obj.TryGetValue(IsAttacking, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddIsAttacking(this IEntity obj, ReactiveVariable<bool> value) => obj.AddValue(IsAttacking, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasIsAttacking(this IEntity obj) => obj.HasValue(IsAttacking);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelIsAttacking(this IEntity obj) => obj.DelValue(IsAttacking);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetIsAttacking(this IEntity obj, ReactiveVariable<bool> value) => obj.SetValue(IsAttacking, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<Transform> GetAttackPoint(this IEntity obj) => obj.GetValue<ReactiveVariable<Transform>>(AttackPoint);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetAttackPoint(this IEntity obj, out ReactiveVariable<Transform> value) => obj.TryGetValue(AttackPoint, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddAttackPoint(this IEntity obj, ReactiveVariable<Transform> value) => obj.AddValue(AttackPoint, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasAttackPoint(this IEntity obj) => obj.HasValue(AttackPoint);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelAttackPoint(this IEntity obj) => obj.DelValue(AttackPoint);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetAttackPoint(this IEntity obj, ReactiveVariable<Transform> value) => obj.SetValue(AttackPoint, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IEvent GetHitEvent(this IEntity obj) => obj.GetValue<IEvent>(HitEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetHitEvent(this IEntity obj, out IEvent value) => obj.TryGetValue(HitEvent, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddHitEvent(this IEntity obj, IEvent value) => obj.AddValue(HitEvent, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasHitEvent(this IEntity obj) => obj.HasValue(HitEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelHitEvent(this IEntity obj) => obj.DelValue(HitEvent);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetHitEvent(this IEntity obj, IEvent value) => obj.SetValue(HitEvent, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IEvent GetHitAction(this IEntity obj) => obj.GetValue<IEvent>(HitAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetHitAction(this IEntity obj, out IEvent value) => obj.TryGetValue(HitAction, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddHitAction(this IEntity obj, IEvent value) => obj.AddValue(HitAction, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasHitAction(this IEntity obj) => obj.HasValue(HitAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelHitAction(this IEntity obj) => obj.DelValue(HitAction);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetHitAction(this IEntity obj, IEvent value) => obj.SetValue(HitAction, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ReactiveVariable<LayerMask> GetTargetLayer(this IEntity obj) => obj.GetValue<ReactiveVariable<LayerMask>>(TargetLayer);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetTargetLayer(this IEntity obj, out ReactiveVariable<LayerMask> value) => obj.TryGetValue(TargetLayer, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddTargetLayer(this IEntity obj, ReactiveVariable<LayerMask> value) => obj.AddValue(TargetLayer, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasTargetLayer(this IEntity obj) => obj.HasValue(TargetLayer);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelTargetLayer(this IEntity obj) => obj.DelValue(TargetLayer);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetTargetLayer(this IEntity obj, ReactiveVariable<LayerMask> value) => obj.SetValue(TargetLayer, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IEvent GetAttackFinished(this IEntity obj) => obj.GetValue<IEvent>(AttackFinished);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetAttackFinished(this IEntity obj, out IEvent value) => obj.TryGetValue(AttackFinished, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddAttackFinished(this IEntity obj, IEvent value) => obj.AddValue(AttackFinished, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasAttackFinished(this IEntity obj) => obj.HasValue(AttackFinished);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelAttackFinished(this IEntity obj) => obj.DelValue(AttackFinished);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetAttackFinished(this IEntity obj, IEvent value) => obj.SetValue(AttackFinished, value);
    }
}
