using UnityEngine;

namespace Game.Configs
{
    public abstract class BaseConfig : ScriptableObject
    {
        [SerializeField]
        private int _hitPoints;

        public int HitPoints => _hitPoints;
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