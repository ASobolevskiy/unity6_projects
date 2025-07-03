using Atomic.Elements;
using Atomic.Entities;

namespace Game.Core.Behaviours
{
    public class EnemyConditionsBehaviour : IEntityInit
    {
        public void Init(IEntity entity)
        {
            var canMove = entity.GetCanMove();
            var isInAttackRange = entity.GetIsInAttackRange();
            
            canMove.Append(() => !isInAttackRange.Value);
        }
    }
}