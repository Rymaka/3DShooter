using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float _chaseRadius = 10f;
    [SerializeField] private float _timeToMaxSpeed = 3f;
    [SerializeField] private float _attackRadius = 2f;
    [SerializeField] protected Animator _animator;
    [SerializeField] protected GameObject _player; //Change to PlayerReference
    private NavMeshAgent _agent;



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
        var distanceToPlayer = Vector3.Distance(_player.transform.position, transform.position);
        if (distanceToPlayer < _chaseRadius)
        {
            if (_agent != null & _player != null)
            {
                ChasePlayer();
            }
        }
    }

    protected virtual void ChasePlayer()
    {
        _agent.SetDestination(_player.transform.position);
    }
}
