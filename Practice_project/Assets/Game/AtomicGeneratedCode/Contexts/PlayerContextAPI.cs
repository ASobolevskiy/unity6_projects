/**
* Code generation. Don't modify! 
**/

using UnityEngine;
using Atomic.Contexts;
using System.Runtime.CompilerServices;
using Atomic.Elements;
using Atomic.Entities;

namespace Atomic.Contexts
{
	public static class PlayerContextAPI
	{
		///Keys
		public const int Player = 10; // Const<IEntity>
		public const int MaxBullets = 12; // ReactiveVariable<int>
		public const int CurrentBullets = 13; // ReactiveVariable<int>
		public const int Hitpoints = 14; // ReactiveVariable<int>


		///Extensions
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Const<IEntity> GetPlayer(this IContext obj) => obj.ResolveValue<Const<IEntity>>(Player);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetPlayer(this IContext obj, out Const<IEntity> value) => obj.TryResolveValue(Player, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddPlayer(this IContext obj, Const<IEntity> value) => obj.AddValue(Player, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelPlayer(this IContext obj) => obj.DelValue(Player);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetPlayer(this IContext obj, Const<IEntity> value) => obj.SetValue(Player, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasPlayer(this IContext obj) => obj.HasValue(Player);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReactiveVariable<int> GetMaxBullets(this IContext obj) => obj.ResolveValue<ReactiveVariable<int>>(MaxBullets);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMaxBullets(this IContext obj, out ReactiveVariable<int> value) => obj.TryResolveValue(MaxBullets, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddMaxBullets(this IContext obj, ReactiveVariable<int> value) => obj.AddValue(MaxBullets, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMaxBullets(this IContext obj) => obj.DelValue(MaxBullets);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMaxBullets(this IContext obj, ReactiveVariable<int> value) => obj.SetValue(MaxBullets, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMaxBullets(this IContext obj) => obj.HasValue(MaxBullets);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReactiveVariable<int> GetCurrentBullets(this IContext obj) => obj.ResolveValue<ReactiveVariable<int>>(CurrentBullets);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetCurrentBullets(this IContext obj, out ReactiveVariable<int> value) => obj.TryResolveValue(CurrentBullets, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddCurrentBullets(this IContext obj, ReactiveVariable<int> value) => obj.AddValue(CurrentBullets, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelCurrentBullets(this IContext obj) => obj.DelValue(CurrentBullets);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetCurrentBullets(this IContext obj, ReactiveVariable<int> value) => obj.SetValue(CurrentBullets, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasCurrentBullets(this IContext obj) => obj.HasValue(CurrentBullets);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReactiveVariable<int> GetHitpoints(this IContext obj) => obj.ResolveValue<ReactiveVariable<int>>(Hitpoints);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetHitpoints(this IContext obj, out ReactiveVariable<int> value) => obj.TryResolveValue(Hitpoints, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddHitpoints(this IContext obj, ReactiveVariable<int> value) => obj.AddValue(Hitpoints, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelHitpoints(this IContext obj) => obj.DelValue(Hitpoints);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetHitpoints(this IContext obj, ReactiveVariable<int> value) => obj.SetValue(Hitpoints, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasHitpoints(this IContext obj) => obj.HasValue(Hitpoints);
    }
}
