using MvxPractice.Presenters.Interfaces;
using UnityEngine;

namespace MvxPractice.Presenters
{
    public class UserInfoPresenter : IUserInfoPresenter
    {
        public string UserName { get; private set; }
        public string UserDescription { get; }
        public Sprite UserAvatarSprite { get; }

        public UserInfoPresenter(UserInfo userInfo)
        {
            UserName = userInfo.Name;
            userInfo.OnNameChanged += HandleNameChanged;
            UserDescription = userInfo.Description;
            UserAvatarSprite = userInfo.Icon;
        }

        private void HandleNameChanged(string obj)
        {
            UserName = obj;
        }
    }
}