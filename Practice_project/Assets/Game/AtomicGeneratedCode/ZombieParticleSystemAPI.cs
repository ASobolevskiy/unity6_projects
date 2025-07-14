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
    public static class ZombieParticleSystemAPI
    {
        ///Keys
        public const int ZombieTakeDamagePSystem = 55; // ParticleSystem


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ParticleSystem GetZombieTakeDamagePSystem(this IEntity obj) => obj.GetValue<ParticleSystem>(ZombieTakeDamagePSystem);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetZombieTakeDamagePSystem(this IEntity obj, out ParticleSystem value) => obj.TryGetValue(ZombieTakeDamagePSystem, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddZombieTakeDamagePSystem(this IEntity obj, ParticleSystem value) => obj.AddValue(ZombieTakeDamagePSystem, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasZombieTakeDamagePSystem(this IEntity obj) => obj.HasValue(ZombieTakeDamagePSystem);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelZombieTakeDamagePSystem(this IEntity obj) => obj.DelValue(ZombieTakeDamagePSystem);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetZombieTakeDamagePSystem(this IEntity obj, ParticleSystem value) => obj.SetValue(ZombieTakeDamagePSystem, value);
    }
}
