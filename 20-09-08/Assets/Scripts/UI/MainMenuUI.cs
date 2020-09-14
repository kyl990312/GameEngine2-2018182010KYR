using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Script.Ui
{
    public class MainMenuUI : MonoBehaviour
    {
        private void Start()
        {
            EventManager.On("Game Started",Hide);
            EventManager.On("Game Paused",Show);
        }

        private void Hide(object obj)
        {
            gameObject.SetActive(false);
        }

        private void Show(object obj)
        {
            gameObject.SetActive(true);
        }
    }
}

