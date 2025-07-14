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
    public sealed class HitPointsPresenter : IViewInit, IViewEnable, IViewDisable
    {
        [SerializeField]
        private TMP_Text _hitPointsText;

        private ReactiveVariable<int> _hitPoints;
        public void Init()
        {
            var playerMap = GameContext.Instance.GetPlayerMap();
            var playerContext = playerMap["Player"];
            _hitPoints = playerContext.GetHitpoints();
        }

        public void Enable()
        {
            _hitPoints.Observe(HitPointsChanged);
        }

        private void HitPointsChanged(int hitPoints)
        {
            _hitPointsText.text = $"Hit points: {hitPoints}";
        }

        public void Disable()
        {
            _hitPoints.Unsubscribe(HitPointsChanged);
        }
    }
}