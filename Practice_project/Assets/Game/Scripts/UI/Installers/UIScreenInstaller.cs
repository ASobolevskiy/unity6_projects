using System.Collections.Generic;
using Atomic.UI;
using Atomic.UI.Installer;
using Game.UI.PopUps;
using Game.UI.Presenters;
using UnityEngine;

namespace Game.UI.Installers
{
    public sealed class UIScreenInstaller : SceneViewControllerInstaller
    {
        [SerializeField]
        private HitPointsPresenter _hitPointsPresenter;

        [SerializeField]
        private AmmoPresenter _ammoPresenter;

        [SerializeField]
        private KillsPresenter _killsPresenter;

        [SerializeField]
        private GameOverPopupShower _gameOverPopupShower;
        
        protected override IEnumerable<IViewController> GetControllers()
        {
            yield return _hitPointsPresenter;
            yield return _ammoPresenter;
            yield return _killsPresenter;
            yield return _gameOverPopupShower;
        }
    }
}