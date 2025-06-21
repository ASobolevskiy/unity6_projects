using Atomic.Entities;
using Game.Behaviours;
using UnityEngine;

namespace Game.Installers
{
    public sealed class BulletMovementInstaller : SceneEntityInstallerBase
    {
        [SerializeField]
        private float _bulletSpeed;

        [SerializeField]
        private Transform _transform;

        private readonly Vector3 _bulletDirection = Vector3.zero;
        
        public override void Install(IEntity entity)
        {
            entity.SetBulletSpeed(_bulletSpeed);
            entity.SetBulletTransform(_transform);
            entity.SetBulletDirection(_bulletDirection);

            entity.AddBehaviour(new BulletMovementBehaviour());
        }
    }
}