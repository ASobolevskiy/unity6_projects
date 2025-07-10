using System;
using UnityEngine;

namespace Game.Utils
{
    [Serializable]
    public sealed class BulletSpawnArguments
    {
        public readonly Vector3 SpawnPoint;
        public readonly Vector3 MoveDirection;

        public BulletSpawnArguments(Vector3 spawnPoint, Vector3 moveDirection)
        {
            SpawnPoint = spawnPoint;
            MoveDirection = moveDirection;
        }
    }
}