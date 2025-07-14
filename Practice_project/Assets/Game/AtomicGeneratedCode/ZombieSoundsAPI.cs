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
    public static class ZombieSoundsAPI
    {
        ///Keys
        public const int ZombieHitSound = 51; // AudioClip
        public const int ZombieDeathSound = 56; // AudioClip


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AudioClip GetZombieHitSound(this IEntity obj) => obj.GetValue<AudioClip>(ZombieHitSound);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetZombieHitSound(this IEntity obj, out AudioClip value) => obj.TryGetValue(ZombieHitSound, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddZombieHitSound(this IEntity obj, AudioClip value) => obj.AddValue(ZombieHitSound, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasZombieHitSound(this IEntity obj) => obj.HasValue(ZombieHitSound);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelZombieHitSound(this IEntity obj) => obj.DelValue(ZombieHitSound);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetZombieHitSound(this IEntity obj, AudioClip value) => obj.SetValue(ZombieHitSound, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AudioClip GetZombieDeathSound(this IEntity obj) => obj.GetValue<AudioClip>(ZombieDeathSound);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetZombieDeathSound(this IEntity obj, out AudioClip value) => obj.TryGetValue(ZombieDeathSound, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddZombieDeathSound(this IEntity obj, AudioClip value) => obj.AddValue(ZombieDeathSound, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasZombieDeathSound(this IEntity obj) => obj.HasValue(ZombieDeathSound);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelZombieDeathSound(this IEntity obj) => obj.DelValue(ZombieDeathSound);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetZombieDeathSound(this IEntity obj, AudioClip value) => obj.SetValue(ZombieDeathSound, value);
    }
}
