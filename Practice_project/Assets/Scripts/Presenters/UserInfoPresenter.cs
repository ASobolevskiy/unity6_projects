using MvxPractice.Presenters.Interfaces;
using UniRx;
using UnityEngine;

namespace MvxPractice.Presenters
{
    public sealed class UserInfoPresenter : IUserInfoPresenter
    {
        public IReadOnlyReactiveProperty<string> UserNameReactive => _userNameReactive;
        private readonly ReactiveProperty<string> _userNameReactive = new();

        public IReadOnlyReactiveProperty<string> UserDescriptionReactive => _userDescriptionReactive;
        private readonly ReactiveProperty<string> _userDescriptionReactive = new();

        public IReadOnlyReactiveProperty<Sprite> UserAvatarSpriteReactive => _userAvatarSpriteReactive;
        private readonly ReactiveProperty<Sprite> _userAvatarSpriteReactive = new();

        private UserInfo _userInfo;

        public UserInfoPresenter(UserInfo userInfo)
        {
            _userInfo = userInfo;
            Init();
        }

        private void Init()
        {
            _userNameReactive.Value = _userInfo.Name;
            _userInfo.OnNameChanged += HandleNameChanged;
            
            _userDescriptionReactive.Value = _userInfo.Description;
            _userInfo.OnDescriptionChanged += HandleDescriptionChanged;

            _userAvatarSpriteReactive.Value = _userInfo.Icon;
            _userInfo.OnIconChanged += HandleIconChanged;
        }

        private void HandleIconChanged(Sprite obj)
        {
            _userAvatarSpriteReactive.Value = obj;
        }

        private void HandleDescriptionChanged(string obj)
        {
            _userDescriptionReactive.Value = obj;
        }

        private void HandleNameChanged(string obj)
        {
            _userNameReactive.Value = obj;
        }

        ~UserInfoPresenter()
        {
            _userInfo.OnNameChanged -= HandleNameChanged;
            _userInfo.OnDescriptionChanged -= HandleDescriptionChanged;
            _userInfo.OnIconChanged -= HandleIconChanged;
        }
    }
}