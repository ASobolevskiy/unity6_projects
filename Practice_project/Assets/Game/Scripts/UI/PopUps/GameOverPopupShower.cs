using System;
using Atomic.Contexts;
using Atomic.Elements;
using Atomic.UI;
using Game.Context;
using UnityEngine;

namespace Game.UI.PopUps
{
    [Serializable]
    public class GameOverPopupShower : IViewInit, IViewEnable, IViewDisable
    {
        [SerializeField]
        private GameObject _gameOverPopup;

        private ReactiveVariable<bool> _isGameOver;
        public void Init()
        {
            _gameOverPopup.SetActive(false);
            _isGameOver = GameContext.Instance.GetIsGameOver();
        }

        public void Enable()
        {
            _isGameOver.Subscribe(HandleGameOver);
        }

        private void HandleGameOver(bool isGameOver)
        {
            if(isGameOver)
                _gameOverPopup.SetActive(true);
        }

        public void Disable()
        {
            _isGameOver.Unsubscribe(HandleGameOver);
        }
    }
}