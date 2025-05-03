using UniRx;
using UnityEngine;

namespace MvxPractice.Presenters.Interfaces
{
    public interface IUserInfoPresenter : IPresenter
    {
        public IReadOnlyReactiveProperty<string> UserNameReactive { get; }
        public IReadOnlyReactiveProperty<string> UserDescriptionReactive { get; }
        public IReadOnlyReactiveProperty<Sprite> UserAvatarSpriteReactive { get; }
    }
}