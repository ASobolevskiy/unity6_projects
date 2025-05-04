using System;
using System.Collections.Generic;
using MvxPractice.Presenters.Interfaces;
using MvxPractice.UIElements;
using MvxPractice.Views;
using TMPro;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace MvxPractice.Popup
{
    public sealed class HeroPopup : MonoBehaviour
    {
        [SerializeField]
        private TMP_Text headerText;

        [SerializeField]
        private Button closeButton;

        [SerializeField]
        private Portrait portrait;

        [SerializeField]
        private TMP_Text description;

        [SerializeField]
        private TMP_Text level;

        [SerializeField]
        private ProgressBar experienceProgressBar;

        [SerializeField]
        private StatBlockView statBlockPrefab;

        [SerializeField]
        private Transform statBlocksContainer;

        [SerializeField]
        private LevelupButton levelUpButton;

        private IHeroPopupPresenter _presenter;
        private CompositeDisposable _subscriptions = new();
        private List<StatBlockView> views = new();

        public void Show(IPresenter args)
        {
            if (args is not IHeroPopupPresenter presenter)
            {
                throw new ArgumentException("Expected IHeroPopupPresenter");
            }

            _subscriptions = new CompositeDisposable();
            _presenter = presenter;

            _presenter.UserInfoPresenter.UserNameReactive.Subscribe(OnNameChanged).AddTo(_subscriptions);
            _presenter.UserInfoPresenter.UserDescriptionReactive.Subscribe(OnDescriptionChanged).AddTo(_subscriptions);
            _presenter.UserInfoPresenter.UserAvatarSpriteReactive.Subscribe(OnSpriteChanged).AddTo(_subscriptions);

            _presenter.ExperiencePresenter.CurrentLevelReactive.Subscribe(OnLevelChanged).AddTo(_subscriptions);
            _presenter.ExperiencePresenter.CurrentExperienceReactive.Subscribe(OnCurrentExpChanged)
                .AddTo(_subscriptions);
            _presenter.ExperiencePresenter.RequiredExperienceReactive.Subscribe(OnRequiredExpChanged)
                .AddTo(_subscriptions);

            _presenter.ExperiencePresenter.CanLevelUpReactive.Subscribe(OnCanLevelUpChanged).AddTo(_subscriptions);
            _presenter.ExperiencePresenter.LevelUpCommand.BindTo(levelUpButton.Button).AddTo(_subscriptions);

            foreach (var statPresenter in _presenter.CharacterInfoPresenter.StatPresentersReactive)
            {
                var view = Instantiate(statBlockPrefab, statBlocksContainer);
                view.InitView(statPresenter);
                views.Add(view);
            }
            
            _presenter.CharacterInfoPresenter.StatPresentersReactive.ObserveAdd().Subscribe(OnStatPresenterAdded)
                .AddTo(_subscriptions);
            _presenter.CharacterInfoPresenter.StatPresentersReactive.ObserveRemove().Subscribe(OnStatPresenterRemoved)
                .AddTo(_subscriptions);

            closeButton.onClick.AddListener(Hide);
            gameObject.SetActive(true);
        }

        private void OnNameChanged(string nameValue)
        {
            headerText.text = nameValue;
        }
        private void OnDescriptionChanged(string descriptionValue)
        {
            description.text = descriptionValue;
        }
        private void OnSpriteChanged(Sprite sprite)
        {
            portrait.SetPortraitSprite(sprite);
        }
        private void OnLevelChanged(int playerLevel)
        {
            level.text = $"Level: {playerLevel}";
        }
        private void OnCurrentExpChanged(int currentExp)
        {
            experienceProgressBar.SetCurrentValue(currentExp);
        }
        private void OnRequiredExpChanged(int requiredExp)
        {
            experienceProgressBar.SetMaxValue(requiredExp);
        }
        private void OnCanLevelUpChanged(bool canLevelUp) => levelUpButton.SetAvailable(canLevelUp);
        private void OnStatPresenterAdded(CollectionAddEvent<ICharacterStatPresenter> addEvent)
        {
            var statPresenter = addEvent.Value;
            var view = Instantiate(statBlockPrefab, statBlocksContainer);
            view.InitView(statPresenter);
            views.Add(view);
        }
        private void OnStatPresenterRemoved(CollectionRemoveEvent<ICharacterStatPresenter> removeEvent)
        {
            var index = removeEvent.Index;
            var viewToRemove = views[index];
            views.Remove(viewToRemove);
            Destroy(viewToRemove.gameObject);
        }

        private void Hide()
        {
            gameObject.SetActive(false);
            foreach (var view in views)
            {
                Destroy(view.gameObject);
            }
            _subscriptions.Dispose();
            closeButton.onClick.RemoveListener(Hide);
        }
    }
}