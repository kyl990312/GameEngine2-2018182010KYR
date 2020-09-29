using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    private NavMeshAgent _agent;
    [SerializeField] private Transform target;
    [SerializeField] private float speed;        // 움직임 속도
    [SerializeField] private float angularSpeed;    // 회전속도
    [SerializeField] private Camera cam;        // 플레이어 카메라
    [SerializeField] private LayerMask layer;    //  레이어

    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
        _agent.speed = speed;
        _agent.angularSpeed = angularSpeed;

    }

    private void Update()
    {
        var mousePos = Input.mousePosition;
        var ray = cam.ScreenPointToRay(mousePos);

        if (Physics.Raycast(ray, out var hitInfo, layer))
        {
            _agent.SetDestination(hitInfo.point);
            
        }
    }
}
