using System;
using AtomicPlayground.Components;
using UnityEngine;

namespace AtomicPlayground
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField]
        private int damage = 1;

        [SerializeField]
        private MoveComponent moveComponent;

        private void Update()
        {
            moveComponent.OnUpdate(Time.deltaTime);
        }

        public void SetDirection(Vector3 direction)
        {
            moveComponent.SetDirection(direction);
        }
    }
}