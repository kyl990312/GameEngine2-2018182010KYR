using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace Script
{
    public class GameManager : SingletonBehaviour<GameManager>
    {
        public GameState state;

        private void Start()
        {
            EventManager.On("Game Started",OnGameStart);
            EventManager.On("Game Ended",OnGameEnd);
            EventManager.On("Game Paused",OnGamePaused);
        }

        private void OnGameStart(object obj)
        {
            state = GameState.Playing;
        }

        private void OnGameEnd(object obj)
        {
            state = GameState.End;
        }

        private void OnGamePaused(object obj)
        {
            state = GameState.Paused;
        }
    }
}
