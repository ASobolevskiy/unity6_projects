using Reflex.Core;
using UnityEngine;

namespace Game.ReflexInstallers
{
    public class SceneScopeInstaller : MonoBehaviour, IInstaller
    {
        [SerializeField]
        private ConfigsInstaller _configsInstaller;
        
        public void InstallBindings(ContainerBuilder containerBuilder)
        {
            _configsInstaller.InstallBindings(containerBuilder);
        }
    }
}