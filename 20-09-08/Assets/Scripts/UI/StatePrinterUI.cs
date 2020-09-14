using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Script.Ui
{
    public class StatePrinterUI : MonoBehaviour
    {
        private Text _text;

        void Start()
        {
            _text = GetComponent<Text>();
        }

        void Update()
        {
            _text.text = GameManager.Instance.state.ToString();
        }
    }
}