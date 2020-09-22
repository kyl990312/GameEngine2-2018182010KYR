using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Script
{
    public class Virus : MonoBehaviour
    {
        private Rigidbody2D _rigid;

        private Vector2 _velocity;

        public float maxHealth = 2f;
        private float _health;
        
        private void Awake()
        {
            _rigid = GetComponent<Rigidbody2D>();
        }

        private void Start()
        {
            EventManager.On("Game Ended", OnGameEnded);
            _health = maxHealth;
        }

        private void Update()
        {
            var velocity = GameManager.Instance.state == GameState.Playing ? Vector2.left : Vector2.zero;
            _rigid.velocity = velocity;
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                var player = other.GetComponent<Player>();
                player.Damage(1.0f);
                gameObject.SetActive(false);
            }
            else if (other.CompareTag("Mask"))
            {
                _health -= 1.0f;
                other.gameObject.SetActive(false);
                if(_health<=0) gameObject.SetActive(false);
            }
        }
        
        private void OnGameEnded(object obj)
        {
            gameObject.SetActive(false);
        }
        
    }
}

