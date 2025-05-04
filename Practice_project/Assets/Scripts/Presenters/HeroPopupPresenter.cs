using MvxPractice.Data;
using MvxPractice.Presenters.Interfaces;

namespace MvxPractice.Presenters
{
    public sealed class HeroPopupPresenter : IHeroPopupPresenter
    {
        public IUserInfoPresenter UserInfoPresenter { get; }
        public IExperiencePresenter ExperiencePresenter { get; }
        public ICharacterInfoPresenter CharacterInfoPresenter { get; }


        public HeroPopupPresenter(HeroInfo heroInfo)
        {
            UserInfoPresenter = new UserInfoPresenter(heroInfo.UserInfoObject);
            ExperiencePresenter = new ExperiencePresenter(heroInfo.PlayerLevelInfoObject);
            CharacterInfoPresenter = new CharacterInfoPresenter(heroInfo.CharacterInfoObject);
        }
    }
}