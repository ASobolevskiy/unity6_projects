using System.Collections;
using System.Collections.Generic;
using Atomic.Entities;
using Game.Pool.Interfaces;
using UnityEngine;

namespace Game.Pool
{
    public sealed class SceneEntityPool : IEntityPool
    {
        private readonly SceneEntity _prefab;

        private readonly Transform _worldTransform;
        private readonly Transform _poolTransform;

        private readonly Queue<SceneEntity> _poolQueue = new();

        public SceneEntityPool(SceneEntity prefab, Transform worldTransform, Transform poolTransform, int initialCount = 0)
        {
            _prefab = prefab;
            _worldTransform = worldTransform;
            _poolTransform = poolTransform;

            for (var i = 0; i < initialCount; i++)
            {
                var entity = SceneEntity.Instantiate(_prefab, _poolTransform);
                _poolQueue.Enqueue(entity);
            }
        }

        public IEntity TakeFromPool()
        {
            if (!_poolQueue.TryDequeue(out SceneEntity entity))
                return SceneEntity.Instantiate(_prefab, _worldTransform);
            entity.transform.SetParent(_worldTransform);
            return entity;
        }

        public void ReturnToPool(IEntity entity)
        {
            var sceneEntity = SceneEntity.Cast(entity);
            sceneEntity.transform.SetParent(_poolTransform);
            _poolQueue.Enqueue(sceneEntity);
        }
    }
}