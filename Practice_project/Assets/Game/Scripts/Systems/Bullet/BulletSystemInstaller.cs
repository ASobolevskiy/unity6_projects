using System;
using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;
using Game.Pool;
using Game.Utils;
using UnityEngine;
using UnityEngine.Serialization;

namespace Game.Systems.Bullet
{
    [Serializable]
    public class BulletSystemInstaller : IContextInstaller
    {
        [SerializeField]
        private SceneEntity _bulletPrefab;
        
        [SerializeField]
        private Transform _bulletPoolTransform;
        
        public void Install(IContext context)
        {
            var worldTransform = context.GetWorldTransform();

            var bulletSystemData = new BulletSystemData()
            {
                BulletPool = new SceneEntityPool(_bulletPrefab, worldTransform, _bulletPoolTransform)
            };

            context.AddBulletSystemData(bulletSystemData);
            context.AddBulletSpawRequest(new BaseEvent<BulletSpawnArguments>());

            context.AddSystem(new BulletSpawnSystem());
            context.AddSystem(new BulletDestroySystem());
        }
    }
}