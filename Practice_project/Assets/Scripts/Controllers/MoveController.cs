using System;
using Atomic.Entities;
using UnityEngine;

namespace AtomicPlayground.Controllers
{
    public class MoveController : MonoBehaviour
    {
        [SerializeField] 
        private SceneEntity target;

        private void Update()
        {
            HandleKeyboard();
        }

        private void HandleKeyboard()
        {
            if (Input.GetKey(KeyCode.W))
            {
                Move(Vector3.forward);
            }
            else if (Input.GetKey(KeyCode.S))
            {
                Move(Vector3.back);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                Move(Vector3.left);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                Move(Vector3.right);
            }
            else
            {
                Move(Vector3.zero);
            }
        }

        private void Move(Vector3 direction)
        {
            target.GetMoveDirection().Value = direction;
        }
    }
}