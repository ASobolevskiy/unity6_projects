using System.Collections.Generic;
using System.Linq;
using Sirenix.OdinInspector;
using UnityEngine;

namespace MvxPractice.Data
{
    public class HeroInfo
    {
        [ShowInInspector]
        private UserInfo userInfo = new();
        
        [Space]
        
        [ShowInInspector]
        private PlayerLevel playerLevelInfo = new();
        
        [Space]
        
        [ShowInInspector]
        private CharacterInfo characterInfo = new();

        public UserInfo UserInfoObject => userInfo;
        public PlayerLevel PlayerLevelInfoObject => playerLevelInfo;
        public CharacterInfo CharacterInfoObject => characterInfo;
        
        [Button]
        public void ParseInfo(HeroData data)
        {
            userInfo.ChangeName(data.Name);
            userInfo.ChangeDescription(data.Description);
            userInfo.ChangeIcon(data.Avatar);
            playerLevelInfo.SetCurrentLevel(data.CurrentLevel);
            List<CharacterStat> characterStats = new();
            foreach (var statDataObject in data.Stats)
            {
                characterStats.Add(statDataObject.ToCharacterStat());
            }
            if(characterStats.Any())
                characterInfo.SetStats(characterStats);
        }
    }
}