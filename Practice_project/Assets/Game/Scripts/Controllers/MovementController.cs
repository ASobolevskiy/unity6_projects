using Atomic.Entities;
using UnityEngine;

namespace Game.Controllers
{
    public sealed class MovementController : MonoBehaviour
    {
        [SerializeField]
        private SceneEntity _targetEntity;
    
        private void Update()
        {
            HandleKeyboard();
        }
    
        private void HandleKeyboard()
        {
            if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
            {
                Move(new Vector3(-1, 0, 1));
            }
            else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
            {
                Move(new Vector3(1,0,1));
            }
            else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
            {
                Move(new Vector3(-1,0,-1));
            }
            else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
            {
                Move(new Vector3(1,0,-1));
            }
            else if (Input.GetKey(KeyCode.W))
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
            _targetEntity.GetMovementDirection().Value = direction;
        }
    }
}

