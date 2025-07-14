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
    public sealed class AmmoPresenter : IViewInit, IViewEnable, IViewDisable
    {
        [SerializeField]
        private TMP_Text _ammoText;

        private ReactiveVariable<int> _maxAmmo;
        private ReactiveVariable<int> _currentAmmo;
        
        public void Init()
        {
            var playerMap = GameContext.Instance.GetPlayerMap();
            var playerContext = playerMap["Player"];
            _maxAmmo = playerContext.GetMaxBullets();
            _currentAmmo = playerContext.GetCurrentBullets();
        }

        public void Enable()
        {
            _currentAmmo.Observe(CurrentAmmoChanged);
        }

        private void CurrentAmmoChanged(int currentAmmo)
        {
            _ammoText.text = $"Bullets: {currentAmmo} / {_maxAmmo.Value}";
        }

        public void Disable()
        {
            _currentAmmo.Unsubscribe(CurrentAmmoChanged);
        }
    }
}