using MvxPractice.Data;
using MvxPractice.Presenters.Interfaces;
using UnityEngine;

namespace MvxPractice.Presenters
{
    public class HeroPopupPresenter : IHeroPopupPresenter
    {
        public IUserInfoPresenter UserInfoPresenter { get; }
        public HeroPopupPresenter(HeroInfo heroInfo)
        {
            UserInfoPresenter = new UserInfoPresenter(heroInfo.UserInfoObject);
        }
    }
}