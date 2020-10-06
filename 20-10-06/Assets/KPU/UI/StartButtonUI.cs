using System.Collections;
using System.Collections.Generic;
using KPU.Manager;
using UnityEngine;

public class StartButtonUI : MonoBehaviour
{
    public void StratGame()
    {
        EventManager.Emit("game_started");
    }

}
