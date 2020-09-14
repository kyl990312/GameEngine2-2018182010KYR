using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Script
{
    public class SpawnController : MonoBehaviour
    {
        public float spawnRate = 1.0f;
        public string spawnTargetName = "virus";

        private IEnumerator _routine;
        void Start()
        {
            EventManager.On("Game Started",OnGameStart);
            EventManager.On("Game Ended",OnGameEnded);
            EventManager.On("Game Paused",OnGamePaused);
            _routine = SpawnRoutine();
        }

        private void OnGameStart(object obj)
        {
            StartCoroutine(_routine);
        }

        private void OnGameEnded(object obj)
        {
            StopCoroutine(_routine);
        }
        
        private void OnGamePaused(object obj)
        {
            StopCoroutine(_routine);
        }
        private IEnumerator SpawnRoutine()
        {
            while (true)
            {
                var go =ObjectPoolManager.Instance.Spawn(spawnTargetName);
                go.transform.position = transform.position;
                go.transform.rotation = transform.rotation;
                yield return new WaitForSeconds(spawnRate);
                
            }
        }
    }
}

