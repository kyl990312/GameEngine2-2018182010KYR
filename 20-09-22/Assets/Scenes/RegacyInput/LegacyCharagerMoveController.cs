using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegacyCharagerMoveController : MonoBehaviour
{
    private CharacterController _characterController;

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        var forwardDir = transform.forward * Input.GetAxis("Vertical");
        var rightDir = transform.right * Input.GetAxis("Horizontal");
        _characterController.Move(forwardDir + rightDir);
    }
}
