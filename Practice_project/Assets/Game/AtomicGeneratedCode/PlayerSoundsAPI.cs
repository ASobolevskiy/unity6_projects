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
    public static class PlayerSoundsAPI
    {
        ///Keys
        public const int AudioSource = 24; // AudioSource
        public const int RifleShotSound = 25; // AudioClip
        public const int RifleDryShotSound = 27; // AudioClip
        public const int PainSound = 36; // AudioClip
        public const int DeathSound = 37; // AudioClip


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AudioSource GetAudioSource(this IEntity obj) => obj.GetValue<AudioSource>(AudioSource);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetAudioSource(this IEntity obj, out AudioSource value) => obj.TryGetValue(AudioSource, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddAudioSource(this IEntity obj, AudioSource value) => obj.AddValue(AudioSource, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasAudioSource(this IEntity obj) => obj.HasValue(AudioSource);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelAudioSource(this IEntity obj) => obj.DelValue(AudioSource);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetAudioSource(this IEntity obj, AudioSource value) => obj.SetValue(AudioSource, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AudioClip GetRifleShotSound(this IEntity obj) => obj.GetValue<AudioClip>(RifleShotSound);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetRifleShotSound(this IEntity obj, out AudioClip value) => obj.TryGetValue(RifleShotSound, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddRifleShotSound(this IEntity obj, AudioClip value) => obj.AddValue(RifleShotSound, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasRifleShotSound(this IEntity obj) => obj.HasValue(RifleShotSound);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelRifleShotSound(this IEntity obj) => obj.DelValue(RifleShotSound);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetRifleShotSound(this IEntity obj, AudioClip value) => obj.SetValue(RifleShotSound, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AudioClip GetRifleDryShotSound(this IEntity obj) => obj.GetValue<AudioClip>(RifleDryShotSound);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetRifleDryShotSound(this IEntity obj, out AudioClip value) => obj.TryGetValue(RifleDryShotSound, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddRifleDryShotSound(this IEntity obj, AudioClip value) => obj.AddValue(RifleDryShotSound, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasRifleDryShotSound(this IEntity obj) => obj.HasValue(RifleDryShotSound);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelRifleDryShotSound(this IEntity obj) => obj.DelValue(RifleDryShotSound);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetRifleDryShotSound(this IEntity obj, AudioClip value) => obj.SetValue(RifleDryShotSound, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AudioClip GetPainSound(this IEntity obj) => obj.GetValue<AudioClip>(PainSound);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetPainSound(this IEntity obj, out AudioClip value) => obj.TryGetValue(PainSound, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddPainSound(this IEntity obj, AudioClip value) => obj.AddValue(PainSound, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasPainSound(this IEntity obj) => obj.HasValue(PainSound);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelPainSound(this IEntity obj) => obj.DelValue(PainSound);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetPainSound(this IEntity obj, AudioClip value) => obj.SetValue(PainSound, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AudioClip GetDeathSound(this IEntity obj) => obj.GetValue<AudioClip>(DeathSound);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetDeathSound(this IEntity obj, out AudioClip value) => obj.TryGetValue(DeathSound, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddDeathSound(this IEntity obj, AudioClip value) => obj.AddValue(DeathSound, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasDeathSound(this IEntity obj) => obj.HasValue(DeathSound);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelDeathSound(this IEntity obj) => obj.DelValue(DeathSound);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetDeathSound(this IEntity obj, AudioClip value) => obj.SetValue(DeathSound, value);
    }
}
