using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MannequinController : EnemyController
{
    [SerializeField] private GameObject _head;
    [SerializeField] private float _maxSpeed = 7f;
    [SerializeField] private float _yOffset = 1f;
    [SerializeField] private float _initialSpeed = 2.5f;
    [SerializeField] private float _fastWalkSpeed = 3f;
    [SerializeField] private float _runningSpeed = 5f;
    [SerializeField] private float _punchDistance = 1f;
    [SerializeField] private float _legAttackDistance = 1f;
    [SerializeField] private float _punchDamage = 10f;
    [SerializeField] private GameObject _hand;
    [SerializeField] private GameObject _leg;
    private float _startSpeed;
    private float _timer;
    private float _accelerationTick;
    private bool _legAttack = false;
    private bool _punch = false;
    private HealthController _healthController;
    private bool _damaged = false;
    
    private void Start()
    {
        _startSpeed = _initialSpeed;
        _agent.speed = _startSpeed;
        _accelerationTick = (_maxSpeed - _initialSpeed)/_timeToMaxSpeed;
        _healthController = _player.GetComponent<HealthController>();
    }

    protected override void Update()
    {
        base.Update();
        if (_punch)
        {
            PunchAttack();
            Debug.Log("punching");
        }

        if (_legAttack)
        {
            LegAttack();
            Debug.Log("Leg Attack");
        }
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

    private void PunchAttack()
    {
        if ((Vector3.Distance(_hand.transform.position, new Vector3(_player.transform.position.x, _player.transform.position.y+_yOffset,_player.transform.position.z))) <= _punchDistance)
        {
            _healthController.TakeDamage(_punchDamage);
            _damaged = true;
            _punch = false;
        }
    }

    private void LegAttack()
    {
        if ((Vector3.Distance(_hand.transform.position, new Vector3(_player.transform.position.x, _player.transform.position.y+_yOffset,_player.transform.position.z))) <= _legAttackDistance)
        {
            _healthController.TakeDamage(_punchDamage);
            _damaged = true;
            _legAttack = false;
        }
    }

    public void EnablePunch()
    {
        _punch = true;
    }

    public void DisablePunch()
    {
        _punch = false;
        if (_damaged)
        {
            _activated = true;
        }
        //TODO: disable On death
    }

    public void EnableLegAttack()
    {
        _legAttack = true;
    }

    public void DisableLegAttack()
    {
        _legAttack = false;
        if (_damaged)
        {
            _activated = true;
        }
        //TODO: disable On death
    }
    
    
    
}
