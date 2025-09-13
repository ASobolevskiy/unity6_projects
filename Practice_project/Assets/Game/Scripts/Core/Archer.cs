using Game.Configs;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Game.Scripts.Core
{
    public class Archer : Unit
    {
        [SerializeField]
        private ArcherConfig _config;

        [ShowInInspector]
        protected  int _hitPoints => _config == null ? 0 : _config.HitPoints;

        [ReadOnly, ShowInInspector]
        private float _moveSpeed => _config == null ? 0 : _config.MoveSpeed;

        [ReadOnly, ShowInInspector]
        private float _attackRange => _config == null ? 0 : _config.AttackRange;

        [ReadOnly, ShowInInspector]
        private Projectile _projectilePrefab => _config == null ? null : _config.ArrowPrefab;

        public override int GetHitPoints() => _hitPoints;

        public override float GetMoveSpeed() => _moveSpeed;

        public override float GetAttackRange() => _attackRange;

        public override Projectile GetProjectile()
        {
            return _projectilePrefab;
        }
    }
}