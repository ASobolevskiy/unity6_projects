using System;
using MvxPractice.Presenters.Interfaces;
using TMPro;
using UniRx;
using UnityEngine;

namespace MvxPractice.Views
{
    public class StatBlockView : MonoBehaviour
    {
        [SerializeField]
        private TMP_Text statText;

        private ICharacterStatPresenter _presenter;
        private CompositeDisposable _subscriptions = new();
        public void InitView(IPresenter args)
        {
            if (args is not ICharacterStatPresenter presenter)
            {
                throw new ArgumentException("Expected ICharacterStatPresenter");
            }

            _presenter = presenter;
            _subscriptions = new CompositeDisposable();

            _presenter.StatValueReactive.Subscribe(OnStatValueChanged).AddTo(_subscriptions);
        }

        private void OnStatValueChanged(int newValue)
        {
            statText.text = $"{_presenter.StatName}: {newValue}";
        }

        private void OnDestroy()
        {
            _subscriptions.Dispose();
        }
    }
}