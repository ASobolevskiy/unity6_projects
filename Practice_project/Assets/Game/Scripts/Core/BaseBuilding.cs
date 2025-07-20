using System;
using Game.Configs;
using Game.Controllers;
using Game.Scripts.Utils;
using Reflex.Attributes;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Game.Scripts.Core
{
    public class BaseBuilding : MonoBehaviour
    {
        [SerializeField]
        private BaseConfig _config;

        [ReadOnly,ShowInInspector]
        private int _hitPoints => _config == null ? 0 : _config.HitPoints;

        [ReadOnly, ShowInInspector]
        private TeamEnum _team => _config == null ? TeamEnum.None : _config.Team;

        [Inject]
        private readonly SpawnController _spawnController;
        
        [Button]
        public void SpawnArcher()
        {
            _spawnController.CreateArcherSpawnRequest(_team, _config.ArcherPrefab);
        }

        public int GetHitPoints() => _hitPoints;
        public TeamEnum GetTeam() => _team;
    }
}