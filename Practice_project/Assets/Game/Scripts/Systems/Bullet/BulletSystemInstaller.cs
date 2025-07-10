using System;
using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;
using Game.Pool;
using Game.Utils;
using UnityEngine;

namespace Game.Systems.Bullet
{
    [Serializable]
    public class BulletSystemInstaller : IContextInstaller
    {
        [SerializeField]
        private SceneEntity _bulletPrefab;

        [SerializeField]
        private Transform _poolTransform;

        [SerializeField]
        private int _initialBulletCount;
        
        public void Install(IContext context)
        {
            var worldTransform = context.GetWorldTransform();

            var bulletSystemData = new BulletSystemData()
            {
                BulletPool = new SceneEntityPool(_bulletPrefab, worldTransform, _poolTransform, _initialBulletCount)
            };

            context.AddBulletSystemData(bulletSystemData);
            context.AddBulletSpawRequest(new BaseEvent<BulletSpawnArguments>());
            context.AddBulletDestroyRequest(new BaseEvent<IEntity>());

            context.AddSystem(new BulletSpawnSystem());
            context.AddSystem(new BulletDestroySystem());
        }
    }
}