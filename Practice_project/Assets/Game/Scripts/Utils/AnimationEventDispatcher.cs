using System;
using UnityEngine;

namespace Game.Utils
{
    public sealed class AnimationEventDispatcher : MonoBehaviour
    {
        public event Action<string> OnEventReceived;

        public void ReceiveEvent(string key)
        {
            OnEventReceived?.Invoke(key);
        }
    }
}