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
    public static class TriggerAPI
    {
        ///Keys
        public const int TriggerReceiver = 53; // TriggerEventReceiver


        ///Extensions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TriggerEventReceiver GetTriggerReceiver(this IEntity obj) => obj.GetValue<TriggerEventReceiver>(TriggerReceiver);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetTriggerReceiver(this IEntity obj, out TriggerEventReceiver value) => obj.TryGetValue(TriggerReceiver, out value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AddTriggerReceiver(this IEntity obj, TriggerEventReceiver value) => obj.AddValue(TriggerReceiver, value);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool HasTriggerReceiver(this IEntity obj) => obj.HasValue(TriggerReceiver);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool DelTriggerReceiver(this IEntity obj) => obj.DelValue(TriggerReceiver);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetTriggerReceiver(this IEntity obj, TriggerEventReceiver value) => obj.SetValue(TriggerReceiver, value);
    }
}
