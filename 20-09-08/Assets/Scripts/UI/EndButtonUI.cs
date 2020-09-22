using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Script.Ui
{
    public class EndButtonUI : MonoBehaviour
    {
        public void Clicked()
        {
            EventManager.Emit("Game Ended", null);
        }
    }

    
}
