using System;
using UnityEngine;

namespace Game.Core.Trigger
{
    public sealed class TriggerEventReceiver : MonoBehaviour
    {
        public event Action<Collider> OnTriggerEntered;
        public event Action<Collider> OnTriggerExited;

        private void OnTriggerEnter(Collider other)
        {
            OnTriggerEntered?.Invoke(other);
        }

        private void OnTriggerExit(Collider other)
        {
            OnTriggerExited?.Invoke(other);
        }
    }
}