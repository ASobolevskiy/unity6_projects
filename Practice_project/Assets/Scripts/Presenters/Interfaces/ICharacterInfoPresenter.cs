using System.Collections.Generic;
using UniRx;

namespace MvxPractice.Presenters.Interfaces
{
    public interface ICharacterInfoPresenter : IPresenter
    {
        IReadOnlyReactiveCollection<ICharacterStatPresenter> StatPresentersReactive { get; }
    }
}