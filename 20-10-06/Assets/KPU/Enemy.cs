using System;
using System.Collections;
using System.Collections.Generic;
using KPU;
using KPU.Manager;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour,IDamagable
{
    [SerializeField] private float sightLevel = 0.4f;
    [SerializeField] private float sightLength = 4f;
    [SerializeField] private LayerMask layerToCast;
    [SerializeField] private float attackRate = 1f;
    [SerializeField] private Status _status;
    private NavMeshAgent _agent;

    private Player _player;

    private EnemyState _state;

    private Coroutine _lifeRoutine;

    private float attackReach = 1f;
    private float _attackTimer;

    // Start is called before the first frame update
    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
        _player = FindObjectOfType<Player>();
    }

    private void OnEnable()
    {
        _state = EnemyState.Idle;
        _lifeRoutine = StartCoroutine(LifeRoutine());
    }

    private void OnDisable()
    {
        StopCoroutine(_lifeRoutine);
    }


    private IEnumerator LifeRoutine()
    {
        while (_state != EnemyState.Dead)
        {
            if (_state == EnemyState.Idle)
            {
                
            }
            else if (_state == EnemyState.Dead)
            {
                if (GameManager.Instance.State == State.GameEnded)
                {
                    break;
                }
            }
            else if (_state == EnemyState.Attack)
            {
                if ((_player.transform.position - transform.position).magnitude > attackReach)
                {
                    _state = EnemyState.Chase;
                    _agent.isStopped = false;
                    break;
                }

                _agent.isStopped = true;
                if (attackRate < _attackTimer)
                {
                    _player.Damage(1f);
                    _attackTimer = 0;
                }

                _attackTimer += Time.deltaTime;
            }
            else if (_state == EnemyState.Search)
            {
                var dir = (_player.transform.position - transform.position).normalized;
                var dot = Vector3.Dot(transform.forward, dir);
                
                if (dot > sightLevel)
                {
                    if (Physics.Raycast(transform.position, dir, out var hit, sightLength, layerToCast))
                    {
                        var hitGameObject =  hit.collider.gameObject;
                        if (hitGameObject.CompareTag("Player"))
                            _state = EnemyState.Chase;
                    }
                }

            }
            else if (_state == EnemyState.Chase)
            {
                _agent.SetDestination(_player.transform.position);
                if ((_player.transform.position - transform.position).magnitude < attackReach)
                {
                    _state = EnemyState.Attack;
                }
            }
        }

        yield return null;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Damage(float damageAmount)
    {
        _status.currentHp = Mathf.Clamp(_status.currentHp - damageAmount, 0, _status.MaxHp);
        if (_status.currentHp <= 0)
        {
            _state = EnemyState.Dead;
            ObjectPoolManager.Instance.Spawn("EnemyDeadEffect", transform.position);
        }
    }
}
