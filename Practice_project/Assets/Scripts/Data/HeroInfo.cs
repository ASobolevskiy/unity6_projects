using Sirenix.OdinInspector;
using UnityEngine;

namespace MvxPractice.Data
{
    [CreateAssetMenu(fileName = "HeroInfo", menuName = "Data/New Hero Info")]
    public class HeroInfo : ScriptableObject
    {
        [SerializeField]
        private UserInfo userInfo = new();

        public UserInfo UserInfoObject => userInfo;
    }
}