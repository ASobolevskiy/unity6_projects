using System;
using MvxPractice.Enums;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.UI;

namespace MvxPractice.UIElements
{
    public sealed class LevelupButton : MonoBehaviour
    {
        [SerializeField]
        private Button levelUpButton;

        [SerializeField]
        private Image background;

        [SerializeField]
        private Sprite availableSprite;

        [SerializeField]
        private Sprite lockedSprite;

        public Button Button => levelUpButton;
        
        [Button]
        public void SetAvailable(bool isAvailable)
        {
            var state = isAvailable ? ButtonState.Available : ButtonState.Locked;
            SetState(state);
        }

        private void SetState(ButtonState state)
        {
            switch (state)
            {
                case ButtonState.Available:
                    levelUpButton.interactable = true;
                    background.sprite = availableSprite;
                    break;
                case ButtonState.Locked:
                    levelUpButton.interactable = false;
                    background.sprite = lockedSprite;
                    break;
                default:
                    throw new Exception($"Undefined button state {state}");
            }
        }
    }
}