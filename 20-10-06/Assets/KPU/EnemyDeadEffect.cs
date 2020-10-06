using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeadEffect : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        Invoke("Hide",1);
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
