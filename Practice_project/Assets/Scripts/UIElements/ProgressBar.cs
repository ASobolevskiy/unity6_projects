using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MvxPractice.UIElements
{
    public sealed class ProgressBar : MonoBehaviour
    {
        [SerializeField]
        private TMP_Text experienceText;

        [SerializeField]
        private Slider slider;
        
        [SerializeField]
        private Sprite uncompletedProgressSprite;

        [SerializeField]
        private Sprite completedProgressSprite;

        private int _currentValue;
        private int _maxValue;
        
        [Button]
        private void SetupSliderSprites()
        {
            var img = slider.fillRect.GetComponent<Image>();
            img.sprite = slider.value < slider.maxValue 
                ? uncompletedProgressSprite 
                : completedProgressSprite;
        }

        public void SetCurrentValue(int value)
        {
            _currentValue = value;
            SetText();
            SetSliderValue();
        }

        public void SetMaxValue(int value)
        {
            _maxValue = value;
            SetText();
            SetSliderValue();
        }

        private void SetText()
        {
            experienceText.text = $"XP: {_currentValue}/{_maxValue}";
        }

        private void SetSliderValue()
        {
            slider.value = (float)_currentValue / _maxValue;
            SetupSliderSprites();
        }
    }
}