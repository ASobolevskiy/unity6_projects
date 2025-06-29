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
    public static class PlayerParticleSystemAPI
    {
        ///Keys
        public const int BulletExplosionPSystem = 26; // ParticleSystem
        public const int PlayerTakeTamagePSystem = 35; // ParticleSystem


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem GetBulletExplosionPSystem(this IEntity obj) => obj.GetValue<ParticleSystem>(BulletExplosionPSystem);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetBulletExplosionPSystem(this IEntity obj, out ParticleSystem value) => obj.TryGetValue(BulletExplosionPSystem, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddBulletExplosionPSystem(this IEntity obj, ParticleSystem value) => obj.AddValue(BulletExplosionPSystem, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasBulletExplosionPSystem(this IEntity obj) => obj.HasValue(BulletExplosionPSystem);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelBulletExplosionPSystem(this IEntity obj) => obj.DelValue(BulletExplosionPSystem);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetBulletExplosionPSystem(this IEntity obj, ParticleSystem value) => obj.SetValue(BulletExplosionPSystem, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem GetPlayerTakeTamagePSystem(this IEntity obj) => obj.GetValue<ParticleSystem>(PlayerTakeTamagePSystem);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetPlayerTakeTamagePSystem(this IEntity obj, out ParticleSystem value) => obj.TryGetValue(PlayerTakeTamagePSystem, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddPlayerTakeTamagePSystem(this IEntity obj, ParticleSystem value) => obj.AddValue(PlayerTakeTamagePSystem, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasPlayerTakeTamagePSystem(this IEntity obj) => obj.HasValue(PlayerTakeTamagePSystem);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelPlayerTakeTamagePSystem(this IEntity obj) => obj.DelValue(PlayerTakeTamagePSystem);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetPlayerTakeTamagePSystem(this IEntity obj, ParticleSystem value) => obj.SetValue(PlayerTakeTamagePSystem, value);
    }
}
