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
        private HeroData heroData;
        
        [Space]
        
        [SerializeField]
        private HeroPopup heroPopup;

        [Space]
        
        [ShowInInspector]
        private HeroInfo heroInfo = new();
        
        [Button]
        private void ShowPopup()
        {
            heroInfo.ParseInfo(heroData);
            var presenter = new HeroPopupPresenter(heroInfo);
            heroPopup.Show(presenter);
        }
    }
}