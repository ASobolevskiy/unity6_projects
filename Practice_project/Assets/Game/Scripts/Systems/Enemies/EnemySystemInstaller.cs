using System;
using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;
using Game.Pool;
using Game.Utils;
using UnityEngine;
using UnityEngine.Serialization;

namespace Game.Systems.Enemies
{
    [Serializable]
    public class EnemySystemInstaller : IContextInstaller
    {
        [SerializeField]
        private SceneEntity _prefab;

        [SerializeField]
        private Transform _enemyPoolTransform;

        [SerializeField]
        private Transform _target;
        
        [SerializeField]
        private EnemySpawnPositions _spawnPositions;

        [SerializeField]
        private float _spawnPeriod;
        
        public void Install(IContext context)
        {
            var worldTransform = context.GetWorldTransform();
            
            var enemySystemData = new EnemySystemData()
            {
                EnemyPool = new SceneEntityPool(_prefab, worldTransform, _enemyPoolTransform),
                SpawnPositions = _spawnPositions,
                SpawnCycle = new Cycle(_spawnPeriod),
                Target = _target
            };

            context.AddEnemySystemData(enemySystemData);

            context.AddSystem(new EnemySpawnSystem());
            context.AddSystem(new EnemyDestroySystem());
        }
    }
}