using Atomic.Elements;
using Atomic.Entities;

namespace Game.Core.Behaviours
{
    public class EnemyConditionsBehaviour : IEntityInit
    {
        public void Init(IEntity entity)
        {
            var canMove = entity.GetCanMove();
            var canAttack = entity.GetCanAttack();
            var isAttackDelaying = entity.GetIsAttackDelaying();
            var isInAttackRange = entity.GetIsInAttackRange();
            var isAttacking = entity.GetIsAttacking();
            
            canMove.Append(() => !isInAttackRange.Value);
            canMove.Append(() => !isAttacking.Value);
            canAttack.Append(() => isInAttackRange.Value);
            canAttack.Append(() => !isAttackDelaying.Value);
        }
    }
}