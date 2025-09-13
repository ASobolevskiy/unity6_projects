using UnityEngine;

namespace Game.Scripts.Core
{
    public class Arrow : Projectile
    {
        [SerializeField]
        private float _arrowSpeed;
        
        [SerializeField]
        private int _arrowDamage;
        
        public override int GetProjectileDamage() => _arrowDamage;

        public override float GetProjectileSpeed() => _arrowSpeed;
    }
}