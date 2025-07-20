using System;
using System.Collections.Generic;
using Game.Scripts.Core;
using Reflex.Core;
using UnityEngine;

namespace Game.ReflexInstallers
{
    [Serializable]
    public class BuildingsInstaller : IInstaller
    {
        [SerializeField]
        private List<BaseBuilding> _baseBuildings;

        public void InstallBindings(ContainerBuilder containerBuilder)
        {
            containerBuilder.AddSingleton(_baseBuildings);
        }
    }
}