using System;
using Atomic.Entities;
using UnityEngine;

namespace AtomicPlayground.Controllers
{
    public class ShootController : MonoBehaviour
    {
        [SerializeField]
        private SceneEntity target;
        private void Update()
        {
            HandleShoot();
        }

        private void HandleShoot()
        {
            if(Input.GetMouseButtonDown(0))
                Shoot();
        }

        private void Shoot()
        {
            target.GetShootRequest().Invoke();
        }
    }
}