using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public struct Status
{
    [SerializeField] private float maxHp;
    public float currentHp;

    public float MaxHp
    {
        get
        {
            return maxHp;
        }
    }
}
