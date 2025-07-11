using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Game.Utils
{
    [Serializable]
    public sealed class EnemySpawnPositions
    {
        [SerializeField]
        private Transform[] _spawnPositions;

        public Transform GetRandomSpawnPosition()
        {
            var index = Random.Range(0, _spawnPositions.Length);
            return _spawnPositions[index];
        }
        
    }
}