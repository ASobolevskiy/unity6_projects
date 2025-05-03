using UnityEngine;

namespace MvxPractice.Presenters.Interfaces
{
    public interface IUserInfoPresenter : IPresenter
    {
        public string UserName { get; }
        public string UserDescription { get; }
        public Sprite UserAvatarSprite { get; }
    }
}