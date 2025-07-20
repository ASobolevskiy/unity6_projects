using Game.Scripts.Core;
using UnityEngine;

namespace Game.Configs
{
    [CreateAssetMenu(fileName = "Archer config", menuName = "Configs/New Archer config")]
    public class ArcherConfig : UnitConfig
    {
        [SerializeField]
        private Arrow _arrowPrefab;
        
        public Arrow ArrowPrefab => _arrowPrefab;
    }
}