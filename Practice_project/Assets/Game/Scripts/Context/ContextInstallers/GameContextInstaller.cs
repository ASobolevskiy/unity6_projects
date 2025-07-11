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
            
            _bulletSystemInstaller.Install(context);
            _enemySystemInstaller.Install(context);
        }
    }
}