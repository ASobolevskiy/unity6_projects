using System;
using Game.Scripts.Utils;
using UnityEngine;

namespace Game.Scripts.Core
{
    [Serializable]
    public class SpawnPoint
    {
        [SerializeField]
        private TeamEnum _team;

        [SerializeField]
        private Transform _point;

        public TeamEnum Team => _team;

        public Transform Point => _point;
    }
}