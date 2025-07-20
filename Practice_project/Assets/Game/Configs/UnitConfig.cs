using Game.Scripts.Core;
using UnityEngine;

namespace Game.Configs
{
    public class UnitConfig : ScriptableObject
    {
        [SerializeField]
        private int _hitPoints;

        [SerializeField]
        private float _moveSpeed;

        public int HitPoints => _hitPoints;

        public float MoveSpeed => _moveSpeed;
    }
}