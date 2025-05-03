using System;
using MvxPractice.Presenters.Interfaces;
using MvxPractice.UIElements;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MvxPractice.Popup
{
    public sealed class HeroPopup : MonoBehaviour
    {
        [SerializeField]
        private TMP_Text _headerText;

        [SerializeField]
        private Button _closeButton;

        [SerializeField]
        private Portrait _portrait;

        [SerializeField]
        private TMP_Text _description;

        private IHeroPopupPresenter _presenter;

        public void Show(IPresenter args)
        {
            if (args is not IHeroPopupPresenter presenter)
            {
                throw new ArgumentException("Expected IHeroPopupPresenter");
            }

            _presenter = presenter;

            _headerText.text = _presenter.UserInfoPresenter.UserName;
            _description.text = _presenter.UserInfoPresenter.UserDescription;
            _portrait.SetPortraitSprite(_presenter.UserInfoPresenter.UserAvatarSprite);
            
            _closeButton.onClick.AddListener(Hide);
            gameObject.SetActive(true);
        }

        private void Hide()
        {
            gameObject.SetActive(false);
            _closeButton.onClick.RemoveListener(Hide);
        }
    }
}