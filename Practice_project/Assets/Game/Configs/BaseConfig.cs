using Game.Scripts.Core;
using Game.Scripts.Utils;
using UnityEngine;

namespace Game.Configs
{
    public abstract class BaseConfig : ScriptableObject
    {
        [SerializeField]
        private int _hitPoints;

        [SerializeField]
        private TeamEnum _team;

        [SerializeField]
        private Archer _archerPrefab;

        [SerializeField]
        private Swordsman _swordsmanPrefab;

        public int HitPoints => _hitPoints;
        
        public TeamEnum Team => _team;
        
        public Archer ArcherPrefab => _archerPrefab;
        
        public Swordsman SwordsmanPrefab => _swordsmanPrefab;
    }
    
    [CreateAssetMenu(fileName = "Red base config", menuName = "Configs/New Red base config")]
    public class RedBaseConfig : BaseConfig
    {
        
    }
    
    [CreateAssetMenu(fileName = "Blue base config", menuName = "Configs/New Blue base config")]
    public class BlueBaseConfig : BaseConfig
    {
        
    }
}