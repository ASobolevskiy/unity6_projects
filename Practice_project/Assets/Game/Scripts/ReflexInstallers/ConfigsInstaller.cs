using System;
using Game.Configs;
using Reflex.Core;
using UnityEngine;
using UnityEngine.Serialization;

namespace Game.ReflexInstallers
{
    [Serializable]
    public class ConfigsInstaller : IInstaller
    {
        [SerializeField]
        private RedBaseConfig _redBaseConfig;

        [SerializeField]
        private BlueBaseConfig _blueBaseConfig;
        
        public void InstallBindings(ContainerBuilder containerBuilder)
        {
            containerBuilder.AddSingleton(_redBaseConfig);
            containerBuilder.AddSingleton(_blueBaseConfig);
        }
    }
}