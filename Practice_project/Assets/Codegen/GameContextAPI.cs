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

namespace Atomic.Contexts
{
	public static class GameContextAPI
	{
		///Keys
		public const int WorldTransform = 1; // Transform
		public const int BulletSystemData = 2; // BulletSystemData
		public const int BulletSpawRequest = 3; // BaseEvent<BulletSpawnArguments>
		public const int BulletDestroyRequest = 4; // BaseEvent<IEntity>


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
		public static BaseEvent<IEntity> GetBulletDestroyRequest(this IContext obj) => obj.ResolveValue<BaseEvent<IEntity>>(BulletDestroyRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryGetBulletDestroyRequest(this IContext obj, out BaseEvent<IEntity> value) => obj.TryResolveValue(BulletDestroyRequest, out value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AddBulletDestroyRequest(this IContext obj, BaseEvent<IEntity> value) => obj.AddValue(BulletDestroyRequest, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool DelBulletDestroyRequest(this IContext obj) => obj.DelValue(BulletDestroyRequest);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SetBulletDestroyRequest(this IContext obj, BaseEvent<IEntity> value) => obj.SetValue(BulletDestroyRequest, value);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool HasBulletDestroyRequest(this IContext obj) => obj.HasValue(BulletDestroyRequest);
    }
}
