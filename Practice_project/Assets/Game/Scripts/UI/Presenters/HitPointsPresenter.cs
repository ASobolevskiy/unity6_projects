using System;
using Atomic.Elements;
using Atomic.Entities;
using Atomic.UI;
using TMPro;
using UnityEngine;

namespace Game.UI.Presenters
{
    [Serializable]
    public sealed class HitPointsPresenter : IViewInit, IViewEnable, IViewDisable
    {
        [SerializeField]
        private SceneEntity _character;
        
        [SerializeField]
        private TMP_Text _hitPointsText;

        private ReactiveVariable<int> _hitPoints;
        public void Init()
        {
            _hitPoints = _character.GetHitpoints();
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