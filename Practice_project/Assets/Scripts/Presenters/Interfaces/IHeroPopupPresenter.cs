namespace MvxPractice.Presenters.Interfaces
{
    public interface IHeroPopupPresenter : IPresenter
    {
        public IUserInfoPresenter UserInfoPresenter { get; }
        public IExperiencePresenter ExperiencePresenter { get; }
        public ICharacterInfoPresenter CharacterInfoPresenter { get; }
    }
}