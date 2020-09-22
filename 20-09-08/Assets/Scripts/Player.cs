using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace  Script{
    public class Player : MonoBehaviour
    {
        public float maxHealth = 10.0f;

        private float _health;

        private IEnumerator _routine;
        private float shootRate = 2f;

        public float Health
        {
            get
            {
                return _health;
            }
        }

        void Start()
        {
            EventManager.On("Game Started",OnGameStart);
            EventManager.On("Game Ended",OnGameEnded);
            gameObject.SetActive(false);
            
            _routine = ShootRoutine();
        }


        void Update()
        {
            
        }

        private void OnGameStart(object obj)
        {
            gameObject.SetActive(true);
            _health = maxHealth;

            StartCoroutine(_routine);
        }

        private void OnGameEnded(object obj)
        {
            gameObject.SetActive(false);
            StopCoroutine(_routine);
        }

        public void Damage(float damage)
        {
            _health -= damage;
            if(_health <= 0)
            {
                EventManager.Emit("Game Ended",null);
            }
        }

        private IEnumerator ShootRoutine()
        {
            while (true)
            {

                var go =ObjectPoolManager.Instance.Spawn("Mask");
                go.transform.position = transform.position;
                go.transform.rotation = transform.rotation;

                yield return new WaitForSeconds(shootRate);
            }
        }
    }
}

