using System.Collections.Generic;
using UnityEngine;

namespace MvxPractice.Data
{
    [CreateAssetMenu(fileName = "HeroData", menuName = "Data/New Hero Data")]
    public class HeroData : ScriptableObject
    {
        [SerializeField]
        private string name;

        [SerializeField]
        private string description;

        [SerializeField]
        private Sprite avatar;
        
        [SerializeField]
        private int currentLevel;

        [SerializeField]
        private List<StatDataObject> stats = new();
        
        public string Name => name;
        public string Description => description;
        public Sprite Avatar => avatar;
        public int CurrentLevel => currentLevel;

        public List<StatDataObject> Stats => stats;
    }
}