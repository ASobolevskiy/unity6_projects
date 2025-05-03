using UniRx;

namespace MvxPractice.Presenters.Interfaces
{
    public interface IExperiencePresenter : IPresenter
    {
        IReadOnlyReactiveProperty<int> CurrentLevelReactive { get; }
        IReadOnlyReactiveProperty<int> CurrentExperienceReactive { get; }
        IReadOnlyReactiveProperty<int> RequiredExperienceReactive { get; }
        IReadOnlyReactiveProperty<bool> CanLevelUpReactive { get; }

        ReactiveCommand LevelUpCommand { get; }
    }
}