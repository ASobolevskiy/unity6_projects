using MvxPractice.Presenters.Interfaces;
using UniRx;
using UnityEngine.PlayerLoop;

namespace MvxPractice.Presenters
{
    public class CharacterStatPresenter : ICharacterStatPresenter
    {
        public string StatName { get; private set; }
        public IReadOnlyReactiveProperty<int> StatValueReactive => _statValueReactive;

        private readonly ReactiveProperty<int> _statValueReactive = new();
        private readonly CharacterStat _characterStat;
        
        public CharacterStatPresenter(CharacterStat characterStat)
        {
            _characterStat = characterStat;
            Init();
        }

        private void Init()
        {
            StatName = _characterStat.Name;
            _statValueReactive.Value = _characterStat.Value;
            _characterStat.OnValueChanged += HandleStatValueChanged;
        }

        private void HandleStatValueChanged(int obj)
        {
            _statValueReactive.Value = obj;
        }

        ~CharacterStatPresenter()
        {
            _characterStat.OnValueChanged -= HandleStatValueChanged;
        }
    }
}
