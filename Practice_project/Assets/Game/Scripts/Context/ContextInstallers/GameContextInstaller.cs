using Atomic.Contexts;
using Game.Systems.Bullet;
using UnityEngine;

namespace Game.Context.ContextInstallers
{
    public class GameContextInstaller : SceneContextInstallerBase
    {
        [SerializeField]
        private Transform _worldTransform;

        [SerializeField]
        private BulletSystemInstaller _bulletSystemInstaller;
        
        public override void Install(IContext context)
        {
            context.AddWorldTransform(_worldTransform);
            
            _bulletSystemInstaller.Install(context);
        }
    }
}