using System;
using Game.Pool.Interfaces;

namespace Game.Systems.Bullet
{
    [Serializable]
    public sealed class BulletSystemData
    {
        public IEntityPool BulletPool;
    }
}