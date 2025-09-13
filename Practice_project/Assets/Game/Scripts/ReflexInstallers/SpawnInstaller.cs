using System;
using System.Collections.Generic;
using Game.Controllers;
using Game.Scripts.Core;
using Reflex.Core;
using UnityEngine;

namespace Game.ReflexInstallers
{
    [Serializable]
    public class SpawnInstaller : IInstaller
    {
        [SerializeField]
        private List<SpawnPoint> _spawnPoints;

        [SerializeField]
        private Transform _worldTransform;
        
        public void InstallBindings(ContainerBuilder containerBuilder)
        {
            var spawnController = new SpawnController(_spawnPoints);
            containerBuilder.AddSingleton(spawnController);
            containerBuilder.AddSingleton(_worldTransform);
        }
    }
}