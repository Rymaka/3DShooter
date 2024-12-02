using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    [Header("Enemy movement")]
    [SerializeField] private float _chaseRadius = 10f;
    [SerializeField] protected float _timeToMaxSpeed = 3f;

    [Header("Enemy interactions")]
    [SerializeField] private float _attackRadius = 2f;
    [SerializeField] protected Animator _animator;
    [SerializeField] protected GameObject _player; //Change to PlayerReference
    protected NavMeshAgent _agent;
    private bool _isChasing = false;
    private bool _isAttacking = false;
    protected bool _activated = false;


    private void Awake()
    {
        OnAwake();
    }
    protected virtual void OnAwake()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    protected virtual void Update()
    {
        if (!_activated)
        {
            var distanceToPlayer = Vector3.Distance(_player.transform.position, transform.position);
            if (distanceToPlayer < _chaseRadius)
            {
                if (_agent != null & _player != null)
                {
                    if (distanceToPlayer < _attackRadius)
                    {
                        AttackPlayer();
                    }
                    else
                    {
                        if (!_isAttacking)
                        {
                            ChasePlayer();
                        }
                    }
                }
            }
            else
            {
                if (_isChasing)
                {
                    StopChasing();
                }
                else
                {
                    _isAttacking = false;
                    _animator.SetTrigger("Idle");
                }
            }
        }
        else
        {
            EndOfActivation();
        }
    }

    protected virtual void EndOfActivation()
    {
        _animator.SetTrigger("Idle");
    }

    protected virtual void AttackPlayer()
    {
        _agent.ResetPath();
        _animator.SetTrigger("Attack");
        _isAttacking = true;
    }

    protected virtual void ChasePlayer()
    {
        _animator.ResetTrigger("Attack");
        _agent.SetDestination(_player.transform.position);
        _isChasing = true;
    }

    protected virtual void StopChasing()
    {
        _isChasing = false;
    }

    public void EndAttacking()
    {
        _isAttacking = false;
        _activated = true;
    }
    
}
