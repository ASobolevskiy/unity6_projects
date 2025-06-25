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
    public static class PlayerSoundsAPI
    {
        ///Keys
        public const int AudioSource = 24; // AudioSource
        public const int RifleShotSound = 25; // AudioClip


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
    }
}
