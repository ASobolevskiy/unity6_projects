using UniRx;

namespace MvxPractice.Presenters.Interfaces
{
    public interface ICharacterStatPresenter : IPresenter
    {
        string StatName { get; }
        IReadOnlyReactiveProperty<int> StatValueReactive { get; }
    }
}