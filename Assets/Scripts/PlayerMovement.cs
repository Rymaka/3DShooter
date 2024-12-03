using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement Speeds")]
    [SerializeField] private float _walkSpeed = 3.0f;
    [SerializeField] private float _sprintMultiplier = 2.0f;

    [Header("Jump Parameters")]
    [SerializeField] private float _jumpForce = 5.0f;
    [SerializeField] private float _gravity = 9.81f;

    [Header("Look Sensitivity")]
    [SerializeField] private float _mouseSensitivity = 2.0f;
    [SerializeField] private float _upDownRange = 80.0f;

    [SerializeField] private CharacterController _characterController;
    private Camera _mainCamera;
    [SerializeField] private GameObject _cameraTarget;
    [SerializeField] private PlayerInputHandler _inputHandler;
    private Vector3 _currentMovement;
    private float _verticalRotation;

    private void Awake()
    {
        //_characterController = GetComponent<CharacterController>();
        _mainCamera = Camera.main;
        //_inputHandler = PlayerInputHandler.Instance;
    }

    private void FixedUpdate()
    {
        HandleMovement();
    }

    private void LateUpdate()
    {
        HandleRotation();
    }

    private void HandleMovement()
    {
        float speed = _walkSpeed * (_inputHandler.SprintValue > 0 ? _sprintMultiplier : 1f);

        Vector3 inputDirection = new Vector3(_inputHandler.MoveInput.x, 0f, _inputHandler.MoveInput.y);
        Vector3 worldDirection = transform.TransformDirection(inputDirection);
        worldDirection.Normalize();

        _currentMovement.x = worldDirection.x * speed;
        _currentMovement.z = worldDirection.z * speed;

        HandleJumping();
        _characterController.Move(_currentMovement * Time.deltaTime);
    }

    private void HandleJumping()
    {
        if(_characterController.isGrounded)
        {
            _currentMovement.y = -0.5f;

            if (_inputHandler.JumpTriggered)
            {
                _currentMovement.y = _jumpForce;
            }
        }
        else
        {
            _currentMovement.y -= _gravity * Time.deltaTime;
        }
    }

    private void HandleRotation()
    {
        float mouseXRotation = (_inputHandler.newLookInput.x) * _mouseSensitivity;
        transform.Rotate(0, mouseXRotation, 0);

        _verticalRotation -= (_inputHandler.newLookInput.y) * _mouseSensitivity;
        _verticalRotation = Mathf.Clamp(_verticalRotation, -_upDownRange, _upDownRange);
        _cameraTarget.transform.localRotation = Quaternion.Euler(_verticalRotation, 0, 0);
    }
}
