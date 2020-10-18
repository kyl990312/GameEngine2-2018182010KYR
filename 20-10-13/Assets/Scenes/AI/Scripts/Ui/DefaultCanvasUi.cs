using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Scenes.AI.Ui
{
    public class DefaultCanvasUi : MonoBehaviour
    {
        [SerializeField] private Slider slider;
        [SerializeField] private Player player;

        private void Start()
        {
            slider.maxValue = player.Stat.MaxHp;
        }

        private void Update()
        {
            slider.value = player.Stat.Hp; 
            
        }

        public void ShowSecondCanvas()
        {
            NavagationalCanvasManger.Instance.ShowCanvas("second canvas");
        }
    }
}

