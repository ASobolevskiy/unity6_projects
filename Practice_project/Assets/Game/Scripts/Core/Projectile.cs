using UnityEngine;

namespace Game.Scripts.Core
{
    public abstract class Projectile : MonoBehaviour
    {
        public abstract int GetProjectileDamage();

        public abstract float GetProjectileSpeed();
    }
}