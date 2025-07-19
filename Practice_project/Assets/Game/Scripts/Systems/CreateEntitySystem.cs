using Entitas;
using Game.Core;
using Reflex.Attributes;
using UnityEngine;

namespace Game.Systems
{
    public sealed class CreateEntitySystem : IInitializeSystem
    {
        private readonly Contexts _contexts;

        [Inject]
        private Transform _firePoint;

        [Inject]
        private Bullet _bulletPrefab;

        public CreateEntitySystem(Contexts contexts)
        {
            _contexts = contexts;
        }

        public void Initialize()
        {
            var entity = _contexts.game.CreateEntity();
            entity.isUnit = true;
            entity.isMovable = true;
            entity.isKeyboardMovable = true;
            entity.AddPosition(Vector3.zero);
            entity.AddMoveDirection(Vector3.zero);
            entity.AddMoveSpeed(1);
            entity.AddWeapon(_firePoint, _bulletPrefab);
            entity.AddCanShoot(true);
            entity.isCanShootFromKeyboard = true;
        }
    }
}