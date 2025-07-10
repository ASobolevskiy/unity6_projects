using Atomic.Entities;

namespace Game.Pool.Interfaces
{
    public interface IEntityPool
    {
        public IEntity TakeFromPool();
        public void ReturnToPool(IEntity entity);
    }
}