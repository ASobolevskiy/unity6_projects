using UnityEngine;

namespace MvxPractice.Presenters.Interfaces
{
    public interface IHeroPopupPresenter : IPresenter
    {
        public IUserInfoPresenter UserInfoPresenter { get; }
    }
}