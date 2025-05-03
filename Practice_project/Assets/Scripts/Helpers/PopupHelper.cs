using MvxPractice.Data;
using MvxPractice.Popup;
using MvxPractice.Presenters;
using Sirenix.OdinInspector;
using UnityEngine;

namespace MvxPractice.Helpers
{
    public sealed class PopupHelper : MonoBehaviour
    {
        [SerializeField]
        private HeroPopup heroPopup;

        [SerializeField]
        private HeroInfo heroInfo;
        
        [Button]
        private void ShowPopup()
        {
            var presenter = new HeroPopupPresenter(heroInfo);
            heroPopup.Show(presenter);
        }
    }
}