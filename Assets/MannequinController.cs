using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MannequinController : EnemyController
{
    [SerializeField] private GameObject _head;
    [SerializeField] private float _maxSpeed;
    [SerializeField] private float _timeToMaxSpeed;
    [SerializeField] private float _initialSpeed;
    private float _startSpeed;

    private void Start()
    {
        _startSpeed = _initialSpeed;
    }
    protected override void ChasePlayer()
    {
        base.ChasePlayer();
        _head.transform.LookAt(_player.transform.position);
        AccerateByTime();
    }

    private void AccerateByTime()
    {
        
    }
    
}
