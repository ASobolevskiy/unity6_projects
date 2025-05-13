using System;
using Atomic.Entities;
using UnityEngine;
using UnityEngine.Serialization;

namespace AtomicPlayground.Controllers
{
    public class MouseLookController : MonoBehaviour
    {
        [SerializeField]
        private SceneEntity _entity;

        [SerializeField]
        private LayerMask _layer;

        private Camera _camera;
        
        private void Start()
        {
            _camera = Camera.main;
        }

        private void Update()
        {
            MouseLook();
        }

        private void MouseLook()
        {
            Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
            if (!Physics.Raycast(ray, out RaycastHit hit, 300f, _layer)) 
                return;
            var entityPos = _entity.transform.position;
            Vector3 targetPosition = hit.point;
            Vector3 direction = targetPosition - entityPos;
            direction.y = 0f;

            if (direction == Vector3.zero) 
                return;
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            _entity.transform.rotation = Quaternion.Euler(0f, lookRotation.eulerAngles.y, 0f);
        }
    }
}