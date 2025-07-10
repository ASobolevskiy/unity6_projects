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
            var canRotate = entity.GetCanRotate();
            var isAttackDelaying = entity.GetIsAttackDelaying();
            var isInAttackRange = entity.GetIsInAttackRange();
            var isAttacking = entity.GetIsAttacking();
            var isDead = entity.GetIsDead();
            
            canMove.Append(() => !isInAttackRange.Value);
            canMove.Append(() => !isAttacking.Value);
            canMove.Append(() => !isDead.Value);
            canAttack.Append(() => isInAttackRange.Value);
            canAttack.Append(() => !isAttackDelaying.Value);
            canAttack.Append(() => !isDead.Value);
            canRotate.Append(() => !isDead.Value);
        }
    }
}