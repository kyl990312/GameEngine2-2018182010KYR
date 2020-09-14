using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Script.Ui
{
    public class GameOverUI : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            EventManager.On("Game Ended", Show);
            EventManager.On("Game Started", Hide);
            EventManager.On("Game Paused", Hide);
            gameObject.SetActive(false);
        }

        private void Show(object obj)
        {
            gameObject.SetActive(true);
        }

        private void Hide(object obj)
        {
            gameObject.SetActive(false);
        }
    }
}

