using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;
using Game.Systems.Bullet;
using Game.Systems.Health;
using UnityEngine;
using UnityEngine.Rendering;

namespace Game.Context.ContextInstallers
{
    public class PlayerContextInstaller : SceneContextInstallerBase
    {
        [SerializeField]
        private SceneEntity _player;
        
        public override void Install(IContext context)
        {
            context.GetPlayerMap().Add("Player", context);
            context.AddPlayer(new Const<IEntity>(_player));
            context.AddMaxBullets(new ReactiveVariable<int>());
            context.AddCurrentBullets(new ReactiveVariable<int>());
            context.AddHitpoints(new ReactiveVariable<int>());

            context.AddSystem(new BulletTrackSystem());
            context.AddSystem(new HealthTrackSystem());
        }
    }
}