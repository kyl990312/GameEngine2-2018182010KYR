using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using KPU.Manager;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour,IDamagable
{
    private NavMeshAgent _agent;

    [SerializeField] private Camera camera;

    private float speed = 1f;

    [SerializeField] private Status status;

    private PlayerState _state;

    [SerializeField] private float shootPower = 20f;
    [SerializeField] private float shootRate = 0.5f;
    private float _shootTimer = 0;

    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
        
    }

    private void OnEnable()
    {
        _state = PlayerState.Idle;
        status.currentHp = status.MaxHp;
    }

    private void Update()
    {
        if (_state == PlayerState.Dead)
        {
            EventManager.Emit("game_over");
            EventManager.Emit("game_ended");
            return;
        }
        
        var dir = (camera.transform.forward * Input.GetAxis(("Vertical")) 
                   + camera.transform.right * Input.GetAxis("Horizontal")).normalized;
        _agent.Move(new Vector3(dir.x,0,dir.z) * Time.deltaTime * speed);
        
        // rotation
        transform.rotation = Quaternion.LookRotation(new Vector3(dir.x, 0, dir.z) * Time.deltaTime * speed);
        
        // shoot
        if (_shootTimer > shootRate)
        {
            _shootTimer = 0f;
            var bulletObject = ObjectPoolManager.Instance.Spawn("Bullet", transform.position);
            bulletObject.SetActive(true);
            var bulletRigid = bulletObject.GetComponent<Rigidbody>();
            bulletRigid.AddForce(transform.forward * shootPower);
        }else
            _shootTimer += Time.deltaTime;
    }

    public void Damage(float damageAmount)
    {
        status.currentHp =Mathf.Clamp(status.currentHp- damageAmount,0,status.MaxHp);
        if (status.currentHp <= 0)
        {
            _state = PlayerState.Dead;
        }
    }
}
