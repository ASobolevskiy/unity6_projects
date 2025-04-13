using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
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
        
        [Button]
        private void SetupSliderSprites()
        {
            var img = slider.fillRect.GetComponent<Image>();
            img.sprite = slider.value < slider.maxValue 
                ? uncompletedProgressSprite 
                : completedProgressSprite;
        }
    }
}