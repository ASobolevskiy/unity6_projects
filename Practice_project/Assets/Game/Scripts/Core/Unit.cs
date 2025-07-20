using Sirenix.OdinInspector;
using UnityEngine;

namespace Game.Scripts.Core
{
    public abstract class Unit : MonoBehaviour
    {
        public abstract int GetHitPoints();

        public abstract float GetMoveSpeed();
    }
}