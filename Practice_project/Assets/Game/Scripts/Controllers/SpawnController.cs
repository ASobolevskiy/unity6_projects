using System.Collections.Generic;
using Game.Scripts.Core;
using Game.Scripts.Utils;
using UnityEngine;

namespace Game.Controllers
{
    public class SpawnController
    {
        private readonly EventsContext _context;
        private readonly List<SpawnPoint> _spawnPoints;
        
        public SpawnController(List<SpawnPoint> spawnPoints)
        {
            _context = Contexts.sharedInstance.events;
            _spawnPoints = spawnPoints;
        }

        public void CreateArcherSpawnRequest(TeamEnum team, Archer prefab)
        {
            Debug.Log($"{team} archer spawn requested");
            var spawnPoint = PickRandomSpawnPointForTeam(team);
            var position = spawnPoint.Point.position;
            var rotation = spawnPoint.Point.rotation;
            var eventEntity = _context.CreateEntity();
            eventEntity.AddPosition(position);
            eventEntity.AddRotation(rotation);
            eventEntity.AddUnitPrefab(prefab);
            eventEntity.isSpawnRequested = true;
            eventEntity.isUnit = true;
            eventEntity.isBlueTeam = team == TeamEnum.Blue;
            eventEntity.isRedTeam = team == TeamEnum.Red;
        }

        private SpawnPoint PickRandomSpawnPointForTeam(TeamEnum team)
        {
            var teamPoints = _spawnPoints.FindAll(sP => sP.Team == team);
            var index = Random.Range(0, teamPoints.Count);
            return teamPoints[index];
        }
    }
}