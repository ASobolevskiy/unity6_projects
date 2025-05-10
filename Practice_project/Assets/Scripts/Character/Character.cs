using System;
using AtomicPlayground.Components;
using UnityEngine;

namespace AtomicPlayground
{
    public class Character : MonoBehaviour
    {
        [SerializeField] 
        private MoveComponent moveComponent;

        [SerializeField]
        private ShootComponent shootComponent;
        private void Update()
        {
            var deltaTime = Time.deltaTime;
            moveComponent.OnUpdate(deltaTime);
            shootComponent.OnUpdate(deltaTime);
        }

        public void SetMoveDirection(Vector3 direction)
        {
            moveComponent.SetDirection(direction);
        }

        public void Shoot()
        {
            shootComponent.Shoot();
        }
    }
}