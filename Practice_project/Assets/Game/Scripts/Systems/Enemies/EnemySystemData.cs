using Atomic.Elements;
using Atomic.Entities;
using Game.Pool.Interfaces;
using Game.Utils;
using UnityEngine;

namespace Game.Systems.Enemies
{
    public class EnemySystemData
    {
        public IEntityPool EnemyPool { get; set; }
        public EnemySpawnPositions SpawnPositions { get; set; }
        public Cycle SpawnCycle { get; set; }
        public Transform Target { get; set; }
    }
}