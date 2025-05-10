using System;
using Atomic.Entities;
using AtomicPlayground.Visual;
using Mechanics;
using UnityEngine;

namespace AtomicPlayground
{
    public class CharacterInstaller : SceneEntityInstallerBase
    {
        [SerializeField]
        private MoveInstaller moveInstaller;
        
        [SerializeField]
        private HealthInstaller healthInstaller;

        [SerializeField]
        private ShootInstaller shootInstaller;

        public override void Install(IEntity entity)
        {
            moveInstaller.Install(entity);
            healthInstaller.Install(entity);
            shootInstaller.Install(entity);
        }
    }
}