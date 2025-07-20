using System.Collections.Generic;
using Game.Scripts.Core;
using Game.Scripts.Utils;
using Reflex.Core;
using UnityEngine;

namespace Game.ReflexInstallers
{
    public class SceneScopeInstaller : MonoBehaviour, IInstaller
    {
        [SerializeField]
        private BuildingsInstaller _buildingsInstaller;

        [Space]
        [SerializeField]
        private SpawnInstaller _spawnInstaller;
        
        public void InstallBindings(ContainerBuilder containerBuilder)
        {
            _buildingsInstaller.InstallBindings(containerBuilder);
            _spawnInstaller.InstallBindings(containerBuilder);
        }
    }
}