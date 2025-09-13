using Entitas;
using UnityEngine;

namespace Game.Scripts.Systems.ExecuteSystems
{
    public class AttackIfTargetInRangeSystem : IExecuteSystem
    {
        private const float ATTACK_DISTANCE_THRESHOLD = 0.5f;
        private readonly IGroup<GameEntity> _attackers;
        private readonly Contexts _contexts;
        
        public AttackIfTargetInRangeSystem(Contexts contexts)
        {
            _contexts = contexts;
            var matchers = new[]
            {
                GameMatcher.Unit,
                GameMatcher.Target,
                GameMatcher.AttackRange,
                GameMatcher.MovementDirection,
                GameMatcher.Weapon
            };
            
            _attackers = contexts.game.GetGroup(GameMatcher.AllOf(matchers));
        }

        public void Execute()
        {
            foreach (var unit in _attackers.GetEntities())
            {
                var attackRange = unit.attackRange.Value;
                var sqrAttackRange = attackRange * attackRange;
                var target = unit.target.Value;
                var directionToTarget = target.position.Value - unit.position.Value;
                var sqrMagnitude = directionToTarget.sqrMagnitude;
                var isInAttackRange = Mathf.Abs(sqrMagnitude - sqrAttackRange) < ATTACK_DISTANCE_THRESHOLD;
                if (isInAttackRange)
                {
                    unit.isMovable = false;
                    unit.isAttacking = true;
                    
                    //TODO trigger attack system
                    if (!unit.weapon.IsRanged) 
                        continue;
                    
                    var eventEntity = _contexts.events.CreateEntity();
                    var firePointPos = unit.weapon.AttackPoint.position;
                    var projectilePosition = unit.sceneView.Value.transform.TransformPoint(firePointPos);
                    var projectileDirection = target.position.Value - projectilePosition;
                    var projectilePrefab = unit.weapon.Prefab;
                    eventEntity.AddMovementDirection(projectileDirection);
                    eventEntity.AddPosition(projectilePosition);
                    eventEntity.AddRotation(Quaternion.LookRotation(projectileDirection.normalized));
                    eventEntity.isProjectile = true;
                    eventEntity.isBlueTeam = unit.isBlueTeam;
                    eventEntity.isRedTeam = unit.isRedTeam;
                    eventEntity.AddProjectilePrefab(projectilePrefab);
                    eventEntity.isProjectileSpawnRequested = true;
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