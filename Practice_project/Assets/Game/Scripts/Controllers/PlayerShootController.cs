using System;
using Atomic.Entities;
using UnityEngine;

namespace Game.Controllers
{
    public class PlayerShootController : MonoBehaviour
    {
        [SerializeField]
        private SceneEntity _target;

        private void Update()
        {
            if (Input.GetMouseButton(0))
            {
                _target.GetShootRequest().Invoke();
            }
        }
    }
}