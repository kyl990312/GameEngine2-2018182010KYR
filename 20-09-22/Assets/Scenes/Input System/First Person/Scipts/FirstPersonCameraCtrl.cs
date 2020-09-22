using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FirstPersonCameraCtrl : MonoBehaviour, PlayerInputAction.IFirstPersonCameraActions
{
    private PlayerInputAction _inputAction;
    private Vector2 _mouseInputVector;

    [SerializeField] private float sensitivity = 1f;
    [SerializeField] private Transform cameraTransform;
    private float _cameraAngle;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void OnEnable()
    {
        if(_inputAction == null) _inputAction = new PlayerInputAction();
        _inputAction.FirstPersonCamera.SetCallbacks(this);
        _inputAction.FirstPersonCamera.Enable();
    }

    private void OnDisable()
    {
        _inputAction.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f,_mouseInputVector.x,0f) * (Time.deltaTime*sensitivity));
        _cameraAngle = Mathf.Clamp((_cameraAngle - _mouseInputVector.y * (Time.deltaTime*sensitivity) ),-90f,90f);
        cameraTransform.localRotation = Quaternion.Euler(new Vector3(_cameraAngle,0f,0f));
    }

    public void OnAnim(InputAction.CallbackContext context)
    {
        _mouseInputVector = context.ReadValue<Vector2>();
        
    }
}
