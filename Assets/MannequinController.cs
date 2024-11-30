using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MannequinController : EnemyController
{
    [SerializeField] private GameObject _head;
    [SerializeField] private GameObject _playerEyes;
    [SerializeField] private float _maxSpeed = 7f;
    [SerializeField] private float _initialSpeed = 2.5f;
    [SerializeField] private float _fastWalkSpeed = 3f;
    [SerializeField] private float _runningSpeed = 5f;
    private float _startSpeed;
    private float _timer;
    private float _accelerationTick;

    private void Start()
    {
        _startSpeed = _initialSpeed;
        _agent.speed = _startSpeed;
        _accelerationTick = (_maxSpeed - _initialSpeed)/_timeToMaxSpeed;
    }
    protected override void ChasePlayer()
    {
        base.ChasePlayer();
        HeadRotation();
        AccelerateByTime();
    }

    private void HeadRotation()
    {
        // Vector3 lookDirection = new Vector3(_playerEyes.transform.position.x, 0, 0);
        // _head.transform.rotation = Quaternion.LookRotation(lookDirection);
        // Debug.Log(lookDirection);
    }
    protected override void StopChasing()
    {
        base.StopChasing();
        _agent.speed = _startSpeed;
        _timer = 0f;
        ResetMovingAnimations();
        _agent.ResetPath();
        _animator.SetTrigger("Idle");
        _activated = true;
    }

    protected override void AttackPlayer()
    {
        base.AttackPlayer();
        ResetMovingAnimations();
        _timer = 0f;
        _agent.speed = _startSpeed;
    }
    private void AccelerateByTime()
    {
        if (_timer < _timeToMaxSpeed && _agent.speed < _maxSpeed)
        {
            _timer += Time.deltaTime;
            _agent.speed += _accelerationTick*Time.deltaTime;
            Debug.Log(_agent.speed);
        }
        MovingAnimationController();
    }

    private void MovingAnimationController()
    {
        if (_agent.speed < _fastWalkSpeed)
        {
            ResetMovingAnimations();
            _animator.SetBool("Walking", true);
        }

        if (_agent.speed > _fastWalkSpeed)
        {
            ResetMovingAnimations();
            _animator.SetBool("FastWalk", true);
        }

        if (_agent.speed > _runningSpeed)
        {
            ResetMovingAnimations();
            _animator.SetBool("Running", true);
        }
    }

    private void ResetMovingAnimations()
    {
        _animator.SetBool("Walking", false);
        _animator.SetBool("FastWalk", false);
        _animator.SetBool("Running", false);
    }
    
}
