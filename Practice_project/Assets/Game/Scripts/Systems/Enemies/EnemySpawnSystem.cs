using Atomic.Contexts;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace Game.Systems.Enemies
{
    public class EnemySpawnSystem : IContextInit, IContextEnable, IContextUpdate, IContextDisable
    {
        private Cycle _spawnCycle;
        private EnemySystemData _data;
        private ReactiveVariable<bool> _isGameOver;
        
        public void Init(IContext context)
        {
            _data = context.GetEnemySystemData();
            _spawnCycle = _data.SpawnCycle;
            _isGameOver = context.GetIsGameOver();
        }
        
        public void Enable(IContext context)
        {
            _spawnCycle.Start();
            _spawnCycle.OnCycle += Spawn;
            _isGameOver.Subscribe(HandleGameOver);
        }

        private void HandleGameOver(bool obj)
        {
            StopSpawning();
        }

        public void Update(IContext context, float deltaTime)
        {
            _spawnCycle.Tick(deltaTime);
        }

        public void Disable(IContext context)
        {
            StopSpawning();
            _isGameOver.Unsubscribe(HandleGameOver);
        }

        private void StopSpawning()
        {
            _spawnCycle.Stop();
            _spawnCycle.OnCycle -= Spawn;
        }

        private void Spawn()
        {
            var enemy = _data.EnemyPool.TakeFromPool();
            var spawnPosition = _data.SpawnPositions.GetRandomSpawnPosition();
            enemy.GetRootTransform().position = spawnPosition.position;
            enemy.SetTarget(_data.Target.transform);
            enemy.GetIsDead().Value = false;
            enemy.GetIsAttacking().Value = false;
        }
    }
}