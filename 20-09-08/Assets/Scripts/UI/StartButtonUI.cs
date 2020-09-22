using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Script.Ui
{
    public class StartButtonUI : MonoBehaviour
    {
        public void Clicked()
        {
            EventManager.Emit("Game Started", null);
        }
    }
}

