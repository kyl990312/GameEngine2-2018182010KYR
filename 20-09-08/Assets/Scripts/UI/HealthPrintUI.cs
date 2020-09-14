using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Script.Ui
{
   public class HealthPrintUI : MonoBehaviour
   {
      public Player player;
      private Slider _slider;
      
      private void Awake()
      {
         _slider = GetComponent<Slider>();
      }

      private void Start()
      {
         EventManager.On("Game Started",OnGameStarted);
         EventManager.On("Game Ended",OnGameEnded);
         EventManager.On("Game Paused",OnGamePaused);
         gameObject.SetActive(false);
      }

      private void OnGameStarted(object obj)
      {
         gameObject.SetActive(true);
      }
      private void OnGameEnded(object obj)
      {
         gameObject.SetActive(false);
      }

      private void OnGamePaused(object obj)
      {
         gameObject.SetActive(false);
      }
      private void Update()
      {
         _slider.value = player.Health / player.maxHealth;
      }
   }
   
}
