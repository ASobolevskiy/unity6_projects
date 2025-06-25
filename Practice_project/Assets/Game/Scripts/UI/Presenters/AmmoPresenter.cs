using System;
using Atomic.Elements;
using Atomic.Entities;
using Atomic.UI;
using TMPro;
using UnityEngine;

namespace Game.UI.Presenters
{
    [Serializable]
    public sealed class AmmoPresenter : IViewInit, IViewEnable, IViewDisable
    {
        [SerializeField]
        private SceneEntity _character;

        [SerializeField]
        private TMP_Text _ammoText;

        private ReactiveVariable<int> _maxAmmo;
        private ReactiveVariable<int> _currentAmmo;
        
        public void Init()
        {
            _maxAmmo = _character.GetMaximumAmmo();
            _currentAmmo = _character.GetCurrentAmmo();
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