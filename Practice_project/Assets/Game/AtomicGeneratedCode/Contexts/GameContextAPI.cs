/**
* Code generation. Don't modify! 
**/

using UnityEngine;
using Atomic.Contexts;
using System.Runtime.CompilerServices;
using Game.Systems.Bullet;
using Game.Utils;
using Atomic.Elements;
using Atomic.Entities;
using Game.Systems.Enemies;
using System.Collections.Generic;

namespace Atomic.Contexts
{
	public static class GameContextAPI
	{
		///Keys
		public const int WorldTransform = 1; // Transform
		public const int BulletSystemData = 2; // BulletSystemData
		public const int BulletSpawRequest = 3; // BaseEvent<BulletSpawnArguments>
		public const int EntityDestroyRequest = 4; // BaseEvent<IEntity>
		public const int EnemySystemData = 5; // EnemySystemData
		public const int MinimumHorizontal = 6; // ReactiveVariable<float>
		public const int MaximumHorizontal = 7; // ReactiveVariable<float>
		public const int MinimumVertical = 8; // ReactiveVariable<float>
		public const int MaximumVertical = 9; // ReactiveVariable<float>
		public const int PlayerMap = 11; // Dictionary<string, IContext>
		public const int EnemyKilledCount = 15; // ReactiveVariable<int>
		public const int IsGameOver = 16; // ReactiveVariable<bool>


		///Extensions
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Transform GetWorldTransform(this IContext obj) => obj.ResolveValue<Transform>(WorldTransform);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetWorldTransform(this IContext obj, out Transform value) => obj.TryResolveValue(WorldTransform, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddWorldTransform(this IContext obj, Transform value) => obj.AddValue(WorldTransform, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelWorldTransform(this IContext obj) => obj.DelValue(WorldTransform);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetWorldTransform(this IContext obj, Transform value) => obj.SetValue(WorldTransform, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasWorldTransform(this IContext obj) => obj.HasValue(WorldTransform);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static BulletSystemData GetBulletSystemData(this IContext obj) => obj.ResolveValue<BulletSystemData>(BulletSystemData);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetBulletSystemData(this IContext obj, out BulletSystemData value) => obj.TryResolveValue(BulletSystemData, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddBulletSystemData(this IContext obj, BulletSystemData value) => obj.AddValue(BulletSystemData, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelBulletSystemData(this IContext obj) => obj.DelValue(BulletSystemData);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetBulletSystemData(this IContext obj, BulletSystemData value) => obj.SetValue(BulletSystemData, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasBulletSystemData(this IContext obj) => obj.HasValue(BulletSystemData);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static BaseEvent<BulletSpawnArguments> GetBulletSpawRequest(this IContext obj) => obj.ResolveValue<BaseEvent<BulletSpawnArguments>>(BulletSpawRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetBulletSpawRequest(this IContext obj, out BaseEvent<BulletSpawnArguments> value) => obj.TryResolveValue(BulletSpawRequest, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddBulletSpawRequest(this IContext obj, BaseEvent<BulletSpawnArguments> value) => obj.AddValue(BulletSpawRequest, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelBulletSpawRequest(this IContext obj) => obj.DelValue(BulletSpawRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetBulletSpawRequest(this IContext obj, BaseEvent<BulletSpawnArguments> value) => obj.SetValue(BulletSpawRequest, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasBulletSpawRequest(this IContext obj) => obj.HasValue(BulletSpawRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static BaseEvent<IEntity> GetEntityDestroyRequest(this IContext obj) => obj.ResolveValue<BaseEvent<IEntity>>(EntityDestroyRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetEntityDestroyRequest(this IContext obj, out BaseEvent<IEntity> value) => obj.TryResolveValue(EntityDestroyRequest, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddEntityDestroyRequest(this IContext obj, BaseEvent<IEntity> value) => obj.AddValue(EntityDestroyRequest, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelEntityDestroyRequest(this IContext obj) => obj.DelValue(EntityDestroyRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetEntityDestroyRequest(this IContext obj, BaseEvent<IEntity> value) => obj.SetValue(EntityDestroyRequest, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasEntityDestroyRequest(this IContext obj) => obj.HasValue(EntityDestroyRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static EnemySystemData GetEnemySystemData(this IContext obj) => obj.ResolveValue<EnemySystemData>(EnemySystemData);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetEnemySystemData(this IContext obj, out EnemySystemData value) => obj.TryResolveValue(EnemySystemData, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddEnemySystemData(this IContext obj, EnemySystemData value) => obj.AddValue(EnemySystemData, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelEnemySystemData(this IContext obj) => obj.DelValue(EnemySystemData);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetEnemySystemData(this IContext obj, EnemySystemData value) => obj.SetValue(EnemySystemData, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasEnemySystemData(this IContext obj) => obj.HasValue(EnemySystemData);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReactiveVariable<float> GetMinimumHorizontal(this IContext obj) => obj.ResolveValue<ReactiveVariable<float>>(MinimumHorizontal);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMinimumHorizontal(this IContext obj, out ReactiveVariable<float> value) => obj.TryResolveValue(MinimumHorizontal, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddMinimumHorizontal(this IContext obj, ReactiveVariable<float> value) => obj.AddValue(MinimumHorizontal, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMinimumHorizontal(this IContext obj) => obj.DelValue(MinimumHorizontal);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMinimumHorizontal(this IContext obj, ReactiveVariable<float> value) => obj.SetValue(MinimumHorizontal, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMinimumHorizontal(this IContext obj) => obj.HasValue(MinimumHorizontal);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReactiveVariable<float> GetMaximumHorizontal(this IContext obj) => obj.ResolveValue<ReactiveVariable<float>>(MaximumHorizontal);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMaximumHorizontal(this IContext obj, out ReactiveVariable<float> value) => obj.TryResolveValue(MaximumHorizontal, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddMaximumHorizontal(this IContext obj, ReactiveVariable<float> value) => obj.AddValue(MaximumHorizontal, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMaximumHorizontal(this IContext obj) => obj.DelValue(MaximumHorizontal);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMaximumHorizontal(this IContext obj, ReactiveVariable<float> value) => obj.SetValue(MaximumHorizontal, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMaximumHorizontal(this IContext obj) => obj.HasValue(MaximumHorizontal);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReactiveVariable<float> GetMinimumVertical(this IContext obj) => obj.ResolveValue<ReactiveVariable<float>>(MinimumVertical);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMinimumVertical(this IContext obj, out ReactiveVariable<float> value) => obj.TryResolveValue(MinimumVertical, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddMinimumVertical(this IContext obj, ReactiveVariable<float> value) => obj.AddValue(MinimumVertical, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMinimumVertical(this IContext obj) => obj.DelValue(MinimumVertical);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMinimumVertical(this IContext obj, ReactiveVariable<float> value) => obj.SetValue(MinimumVertical, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMinimumVertical(this IContext obj) => obj.HasValue(MinimumVertical);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReactiveVariable<float> GetMaximumVertical(this IContext obj) => obj.ResolveValue<ReactiveVariable<float>>(MaximumVertical);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetMaximumVertical(this IContext obj, out ReactiveVariable<float> value) => obj.TryResolveValue(MaximumVertical, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddMaximumVertical(this IContext obj, ReactiveVariable<float> value) => obj.AddValue(MaximumVertical, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelMaximumVertical(this IContext obj) => obj.DelValue(MaximumVertical);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetMaximumVertical(this IContext obj, ReactiveVariable<float> value) => obj.SetValue(MaximumVertical, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasMaximumVertical(this IContext obj) => obj.HasValue(MaximumVertical);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Dictionary<string, IContext> GetPlayerMap(this IContext obj) => obj.ResolveValue<Dictionary<string, IContext>>(PlayerMap);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetPlayerMap(this IContext obj, out Dictionary<string, IContext> value) => obj.TryResolveValue(PlayerMap, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddPlayerMap(this IContext obj, Dictionary<string, IContext> value) => obj.AddValue(PlayerMap, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelPlayerMap(this IContext obj) => obj.DelValue(PlayerMap);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetPlayerMap(this IContext obj, Dictionary<string, IContext> value) => obj.SetValue(PlayerMap, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasPlayerMap(this IContext obj) => obj.HasValue(PlayerMap);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReactiveVariable<int> GetEnemyKilledCount(this IContext obj) => obj.ResolveValue<ReactiveVariable<int>>(EnemyKilledCount);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetEnemyKilledCount(this IContext obj, out ReactiveVariable<int> value) => obj.TryResolveValue(EnemyKilledCount, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddEnemyKilledCount(this IContext obj, ReactiveVariable<int> value) => obj.AddValue(EnemyKilledCount, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelEnemyKilledCount(this IContext obj) => obj.DelValue(EnemyKilledCount);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetEnemyKilledCount(this IContext obj, ReactiveVariable<int> value) => obj.SetValue(EnemyKilledCount, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasEnemyKilledCount(this IContext obj) => obj.HasValue(EnemyKilledCount);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReactiveVariable<bool> GetIsGameOver(this IContext obj) => obj.ResolveValue<ReactiveVariable<bool>>(IsGameOver);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetIsGameOver(this IContext obj, out ReactiveVariable<bool> value) => obj.TryResolveValue(IsGameOver, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddIsGameOver(this IContext obj, ReactiveVariable<bool> value) => obj.AddValue(IsGameOver, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelIsGameOver(this IContext obj) => obj.DelValue(IsGameOver);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetIsGameOver(this IContext obj, ReactiveVariable<bool> value) => obj.SetValue(IsGameOver, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasIsGameOver(this IContext obj) => obj.HasValue(IsGameOver);
    }
}
