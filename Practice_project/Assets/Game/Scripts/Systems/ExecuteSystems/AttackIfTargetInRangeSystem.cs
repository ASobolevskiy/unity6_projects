using Entitas;
using UnityEngine;

namespace Game.Scripts.Systems.ExecuteSystems
{
    public class AttackIfTargetInRangeSystem : IExecuteSystem
    {
        private const float ATTACK_DISTANCE_THRESHOLD = 0.5f;
        private readonly IGroup<GameEntity> _attackers;
        
        public AttackIfTargetInRangeSystem(Contexts contexts)
        {
            var matchers = new[]
            {
                GameMatcher.Unit,
                GameMatcher.Target,
                GameMatcher.AttackRange,
                GameMatcher.MovementDirection
            };
            
            _attackers = contexts.game.GetGroup(GameMatcher.AllOf(matchers));
        }

        public void Execute()
        {
            foreach (var unit in _attackers.GetEntities())
            {
                var sqrDistance = unit.attackRange.Value * unit.attackRange.Value;
                var sqrMagnitude = (unit.target.Value.position.Value - unit.position.Value).sqrMagnitude;
                var isInAttackRange = Mathf.Abs(sqrMagnitude - sqrDistance) < ATTACK_DISTANCE_THRESHOLD;
                if (isInAttackRange)
                {
                    unit.isMovable = false;
                    unit.isAttacking = true;
                }
                else
                {
                    unit.isMovable = true;
                    unit.isAttacking = false;
                }
            }
        }
    }
}