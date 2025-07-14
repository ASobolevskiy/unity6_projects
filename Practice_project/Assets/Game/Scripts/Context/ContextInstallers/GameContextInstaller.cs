using System.Collections.Generic;
using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;
using Game.Systems.Bullet;
using Game.Systems.Enemies;
using UnityEngine;

namespace Game.Context.ContextInstallers
{
    public class GameContextInstaller : SceneContextInstallerBase
    {
        [SerializeField]
        private Transform _worldTransform;

        [SerializeField]
        private BulletSystemInstaller _bulletSystemInstaller;

        [SerializeField]
        private EnemySystemInstaller _enemySystemInstaller;
        
        public override void Install(IContext context)
        {
            context.AddWorldTransform(_worldTransform);
            context.AddEntityDestroyRequest(new BaseEvent<IEntity>());
            
            var mainCam = Camera.main;
            var cameraPosition = mainCam.transform.position;
            var bottomLeftPoint = mainCam.ViewportToWorldPoint(new Vector3(0, 0, cameraPosition.y));
            var topRightPoint = mainCam.ViewportToWorldPoint(new Vector3(1, 1, cameraPosition.y));
            context.AddMinimumHorizontal(bottomLeftPoint.x);
            context.AddMaximumHorizontal(topRightPoint.x);
            context.AddMinimumVertical(bottomLeftPoint.z);
            context.AddMaximumVertical(topRightPoint.z);
            context.AddPlayerMap(new Dictionary<string, IContext>());
            context.AddEnemyKilledCount(new ReactiveVariable<int>());
            context.AddIsGameOver(new ReactiveVariable<bool>());
            
            _bulletSystemInstaller.Install(context);
            _enemySystemInstaller.Install(context);
        }
    }
}