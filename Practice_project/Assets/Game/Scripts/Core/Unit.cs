using Sirenix.OdinInspector;
using UnityEngine;

namespace Game.Scripts.Core
{
    public abstract class Unit : MonoBehaviour
    {
        [SerializeReference]
        private Transform _attackPoint;

        [ShowInInspector, ReadOnly]
        private Vector3 _attackPointPosition => _attackPoint.position;
        
        public abstract int GetHitPoints();

        public abstract float GetMoveSpeed();

        public abstract float GetAttackRange();

        public virtual Projectile GetProjectile()
        {
            return null;
        }

        public Transform GetAttackPoint() => _attackPoint;
    }
}