using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FirstPersonMoveCtrl : MonoBehaviour, PlayerInputAction.IFirstPersonShooterActions
{
    private PlayerInputAction _inputAction;

    private Vector2 inputVector;

    private CharacterController _characterController;

    [SerializeField] private float characterMoveSpeed = 10f;
    [SerializeField] private Transform groundedCheckPosition;
    [SerializeField] private LayerMask groundLayer;

    private const float gravity = -9.81f;
    private float _fallingSpeed = 0f;

    private bool _isGrounded;
    
    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _isGrounded = Physics.CheckSphere(groundedCheckPosition.position,0.1f,groundLayer);
        if (_isGrounded) _fallingSpeed = 0f;
        
        var dir  = (transform.forward * inputVector.y + transform.right * inputVector.x) * (Time.deltaTime * characterMoveSpeed);
        _characterController.Move(dir);
        
        _fallingSpeed += Time.deltaTime * gravity;
        _characterController.Move(new Vector3(0, _fallingSpeed, 0));
    }

    private void OnEnable()
    {
        if(_inputAction == null) _inputAction = new PlayerInputAction();
        _inputAction.FirstPersonShooter.SetCallbacks(this);
        _inputAction.FirstPersonShooter.Enable();
    }

    private void OnDisable()
    {
        _inputAction.Disable();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        inputVector = context.ReadValue<Vector2>();
    }

    public void OnAnim(InputAction.CallbackContext context)
    {
        
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        
    }

    public void OnSprint(InputAction.CallbackContext context)
    {
        
    }
}
