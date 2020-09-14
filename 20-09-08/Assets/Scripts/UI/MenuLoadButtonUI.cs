using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Script.Ui
{
    public class MenuLoadButtonUI : MonoBehaviour
    {
        private void Start()
        {
            EventManager.On("Game Paused",Hide);
            EventManager.On("Game Started",Show);
        }
        
        public void Clicked() => EventManager.Emit("Game Paused", null);

        private void Hide(object obj) => gameObject.SetActive(false);

        private void Show(object obj) => gameObject.SetActive(true);
        
    }
}
