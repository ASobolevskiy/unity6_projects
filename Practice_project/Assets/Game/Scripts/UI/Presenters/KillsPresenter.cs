using System;
using Atomic.Contexts;
using Atomic.Elements;
using Atomic.UI;
using Game.Context;
using TMPro;
using UnityEngine;

namespace Game.UI.Presenters
{
    [Serializable]
    public class KillsPresenter : IViewInit, IViewEnable, IViewDisable
    {
        [SerializeField]
        private TMP_Text _killsText;
        
        private ReactiveVariable<int> _killsCount;
        public void Init()
        {
            _killsCount = GameContext.Instance.GetEnemyKilledCount();
            
            _killsCount.Observe(ObserveKillsCount);
        }

        private void ObserveKillsCount(int obj)
        {
            _killsText.text = $"KILLS: {_killsCount.Value}";
        }

        public void Enable()
        {
            
        }

        public void Disable()
        {
            
        }
    }
}