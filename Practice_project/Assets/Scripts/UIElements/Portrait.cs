using UnityEngine;
using UnityEngine.UI;

namespace MvxPractice.UIElements
{
    public sealed class Portrait : MonoBehaviour
    {
        [SerializeField]
        private Image portrait;

        public void SetPortraitSprite(Sprite icon) => portrait.sprite = icon;
    }
}