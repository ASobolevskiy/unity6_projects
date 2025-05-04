using System;
using System.Collections.Generic;
using System.Linq;
using MvxPractice.Presenters.Interfaces;
using UniRx;

namespace MvxPractice.Presenters
{
    public class CharacterInfoPresenter : ICharacterInfoPresenter
    {
        public IReadOnlyReactiveCollection<ICharacterStatPresenter> StatPresentersReactive => _statPresentersReactive;

        private readonly CharacterInfo _characterInfo;
        private readonly List<CharacterStat> _stats;
        private readonly ReactiveCollection<ICharacterStatPresenter> _statPresentersReactive = new();
        
        public CharacterInfoPresenter(CharacterInfo characterInfo)
        {
            _characterInfo = characterInfo;
            _stats = _characterInfo.GetStats().ToList();
            Init();
        }

        private void Init()
        {
            foreach (var stat in _stats)
            {
                var statPresenter = new CharacterStatPresenter(stat);
                _statPresentersReactive.Add(statPresenter);
            }
            _characterInfo.OnStatAdded += HandleStatAdded;
            _characterInfo.OnStatRemoved += HandleStatRemoved;
        }
        
        private void HandleStatAdded(CharacterStat obj)
        {
            _stats.Add(obj);
            var statPresenter = new CharacterStatPresenter(obj);
            try
            {
                _statPresentersReactive.Add(statPresenter);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }
        
        private void HandleStatRemoved(CharacterStat obj)
        {
            var index = _stats.FindIndex(stat => stat == obj);
            _stats.RemoveAt(index);
            _statPresentersReactive.RemoveAt(index);
        }

        ~CharacterInfoPresenter()
        {
            _characterInfo.OnStatAdded -= HandleStatAdded;
            _characterInfo.OnStatRemoved -= HandleStatRemoved;
        }
    }
}