using Atomic.Elements;
using Atomic.Entities;

namespace Game.Core.Behaviours
{
    public class PlayerConditionsBehaviour : IEntityInit
    {
        public void Init(IEntity entity)
        {
            var isDead = entity.GetIsDead();
            var canShoot = entity.GetCanShoot();
            var canRotate = entity.GetCanRotate();
            var canMove = entity.GetCanMove();
            var canReplenishBullets = entity.GetCanReplenishBullets();
            
            canMove.Append(() => !isDead.Value);
            canShoot.Append(() => !isDead.Value);
            canRotate.Append(() => !isDead.Value);
            canReplenishBullets.Append(() => !isDead.Value);
        }
    }
}