using Game.Core;
using Reflex.Core;
using UnityEngine;

namespace Game.Reflex
{
    public class SceneInstaller : MonoBehaviour, IInstaller
    {
        [SerializeField]
        private GameObject _unit;

        [SerializeField]
        private Bullet _bulletPrefab;

        [SerializeField]
        private Transform _firePoint;
        
        public void InstallBindings(ContainerBuilder containerBuilder)
        {
            containerBuilder.AddSingleton(_unit);
            containerBuilder.AddSingleton(_bulletPrefab);
            containerBuilder.AddSingleton(_firePoint);
        }
    }
}