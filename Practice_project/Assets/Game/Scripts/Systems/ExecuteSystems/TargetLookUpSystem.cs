using Entitas;
using Game.Scripts.Utils;
using UnityEngine;

namespace Game.Scripts.Systems.ExecuteSystems
{
    public class TargetLookUpSystem : IExecuteSystem
    {
        private readonly Contexts _contexts;
        private readonly IGroup<GameEntity> _redTeamUnits;
        private readonly IGroup<GameEntity> _blueTeamUnis;

        public TargetLookUpSystem(Contexts contexts)
        {
            _contexts = contexts;
            var redTeamUnitsMatches = new[]
            {
                GameMatcher.RedTeam,
                GameMatcher.Position
            };
            var blueTeamUnitsMatches = new[]
            {
                GameMatcher.BlueTeam,
                GameMatcher.Position
            };
            _redTeamUnits = contexts.game.GetGroup(GameMatcher.AllOf(redTeamUnitsMatches));
            _blueTeamUnis = contexts.game.GetGroup(GameMatcher.AllOf(blueTeamUnitsMatches));
        }

        public void Execute()
        {
            FindTargetForTeam(TeamEnum.Blue);
            FindTargetForTeam(TeamEnum.Red);
        }

        private void FindTargetForTeam(TeamEnum team)
        {
            switch (team)
            {
                case TeamEnum.Blue:
                {
                    foreach (var unit in _blueTeamUnis.GetEntities())
                    {
                        if (!unit.isUnit || unit.isAttacking || unit.hasTarget)
                            continue;
                        FindClosestToUnit(unit, _redTeamUnits.GetEntities());
                    }
                    break;
                }
                case TeamEnum.Red:
                {
                    foreach (var unit in _redTeamUnits.GetEntities())
                    {
                        if(!unit.isUnit || unit.isAttacking|| unit.hasTarget)
                            continue;
                        FindClosestToUnit(unit, _blueTeamUnis.GetEntities());
                    }
                    break;
                }
                default:
                    return;
            }
        }

        private void FindClosestToUnit(GameEntity unit, GameEntity[] oppositeTeamUnits)
        {
            GameEntity target = null;
            var directionToTarget = Vector3.zero;
            var minMagnitude = float.MaxValue;
            foreach (var opposedUnit in oppositeTeamUnits)
            {
                var direction = opposedUnit.position.Value - unit.position.Value;
                var magnitude = direction.sqrMagnitude;
                
                if (!(minMagnitude > magnitude)) 
                    continue;
                
                minMagnitude = magnitude;
                target = opposedUnit;
                directionToTarget = direction;
            }

            if (target == null) 
                return;
            
            unit.ReplaceTarget(target);
            unit.ReplaceMovementDirection(directionToTarget);
        }
    }
}