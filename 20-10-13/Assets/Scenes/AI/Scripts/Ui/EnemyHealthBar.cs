using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Scenes.AI.Ui
{
    public class EnemyHealthBar : MonoBehaviour
    {
        private Slider _slider;
        private RectTransform _rectTransform;
        private Camera _camera;
        private Enemy _enemy;
        private Canvas _canvas;
        private Vector2 _offset;

        private void Awake()
        {
            _slider = GetComponent<Slider>();
            _rectTransform = GetComponent<RectTransform>();
            _camera = FindObjectOfType<Camera>();
        }

        public void Initialize(Enemy enemy, Canvas targetCanvas,Vector2 offset)
        {
            _enemy = enemy;
            _slider.maxValue = enemy.Stat.MaxHp;
            _canvas = targetCanvas;
            _offset = offset;
        }

        private void Update()
        {
            if (_enemy != null)
            {

                _slider.value = _enemy.Stat.Hp;
                var viewportPoint = _camera.WorldToViewportPoint(_enemy.transform.position); // 0~1 사이값으로 나온다
                var canvasWidth = _canvas.pixelRect.width;
                var canvasHeight = _canvas.pixelRect.height + _offset.y;
                _rectTransform.anchoredPosition =
                    new Vector2(viewportPoint.x * canvasWidth, viewportPoint.y * canvasHeight);

                if (_enemy.enabled == false) enabled = false;
            }
        }
    }
}

