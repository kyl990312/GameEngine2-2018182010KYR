using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using KPU;
using UnityEditorInternal;
using UnityEngine;

namespace Scenes.AI.Ui{
    public class NavagationalCanvasManger : SingletonBehaviour<NavagationalCanvasManger>
    {
        private List<NavigationalCanvas> _navigationalCanvases;

        private void Awake()
        {
            _navigationalCanvases = GetComponentsInChildren<NavigationalCanvas>(true).ToList();
        }

        public void ShowCanvas(string canvasName)
        {
            var foundedCanvas = _navigationalCanvases.FirstOrDefault(c=>c.CanvasName == canvasName);
            if (foundedCanvas != null)
            {
                _navigationalCanvases.Remove(foundedCanvas);
                _navigationalCanvases.Add(foundedCanvas);
                for (var i = 0; i < _navigationalCanvases.Count; ++i)
                {
                    var navigationalCanvas = _navigationalCanvases[i];
                    var canvasComponent = navigationalCanvas.GetComponent<Canvas>();
                    
                    navigationalCanvas.gameObject.SetActive(true);
                    canvasComponent.overrideSorting = true;
                    canvasComponent.sortingOrder = i;
                    navigationalCanvas.gameObject.SetActive(false);
                }
                foundedCanvas.gameObject.SetActive(true);
            }
        }
    }
}
