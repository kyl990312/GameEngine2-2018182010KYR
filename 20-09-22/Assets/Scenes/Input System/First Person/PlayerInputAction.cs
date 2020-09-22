// GENERATED AUTOMATICALLY FROM 'Assets/Scenes/Input System/First Person/PlayerInputAction.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputAction : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputAction()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputAction"",
    ""maps"": [
        {
            ""name"": ""FirstPersonShooter"",
            ""id"": ""28673e72-1199-48c1-90bc-a56797014d28"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""78a76fde-c2eb-4e58-be84-f2dfdcaca014"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""06476e03-6a98-46dd-b5ce-fa8744279212"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""71f73f41-d91f-4edd-909f-4f47f76b3967"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""29fee788-6d9b-4732-a846-8c625e1d6e3d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""4861187c-265c-4209-a696-6e80e264faeb"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""bd935930-2933-4af5-890a-3249beff6fb4"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b4961d7d-5a99-44d2-abac-4bc40a26faab"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d52c75d9-cb97-4a31-a273-89888a3d0bc8"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b5b0244f-4d1f-434b-b6cc-175d72d80e56"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""34ab9757-2c6a-4ec9-9cc1-bb9cb3ead6b1"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""FirstPersonCamera"",
            ""id"": ""de790edd-bc9a-4455-9033-36f769292963"",
            ""actions"": [
                {
                    ""name"": ""Anim"",
                    ""type"": ""PassThrough"",
                    ""id"": ""dbb48e30-87f4-434e-a766-48823df9ac19"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a369fb82-0d30-4b93-b81b-a37a039a3511"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Anim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // FirstPersonShooter
        m_FirstPersonShooter = asset.FindActionMap("FirstPersonShooter", throwIfNotFound: true);
        m_FirstPersonShooter_Move = m_FirstPersonShooter.FindAction("Move", throwIfNotFound: true);
        m_FirstPersonShooter_Jump = m_FirstPersonShooter.FindAction("Jump", throwIfNotFound: true);
        m_FirstPersonShooter_Sprint = m_FirstPersonShooter.FindAction("Sprint", throwIfNotFound: true);
        // FirstPersonCamera
        m_FirstPersonCamera = asset.FindActionMap("FirstPersonCamera", throwIfNotFound: true);
        m_FirstPersonCamera_Anim = m_FirstPersonCamera.FindAction("Anim", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // FirstPersonShooter
    private readonly InputActionMap m_FirstPersonShooter;
    private IFirstPersonShooterActions m_FirstPersonShooterActionsCallbackInterface;
    private readonly InputAction m_FirstPersonShooter_Move;
    private readonly InputAction m_FirstPersonShooter_Jump;
    private readonly InputAction m_FirstPersonShooter_Sprint;
    public struct FirstPersonShooterActions
    {
        private @PlayerInputAction m_Wrapper;
        public FirstPersonShooterActions(@PlayerInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_FirstPersonShooter_Move;
        public InputAction @Jump => m_Wrapper.m_FirstPersonShooter_Jump;
        public InputAction @Sprint => m_Wrapper.m_FirstPersonShooter_Sprint;
        public InputActionMap Get() { return m_Wrapper.m_FirstPersonShooter; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FirstPersonShooterActions set) { return set.Get(); }
        public void SetCallbacks(IFirstPersonShooterActions instance)
        {
            if (m_Wrapper.m_FirstPersonShooterActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_FirstPersonShooterActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_FirstPersonShooterActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_FirstPersonShooterActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_FirstPersonShooterActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_FirstPersonShooterActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_FirstPersonShooterActionsCallbackInterface.OnJump;
                @Sprint.started -= m_Wrapper.m_FirstPersonShooterActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_FirstPersonShooterActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_FirstPersonShooterActionsCallbackInterface.OnSprint;
            }
            m_Wrapper.m_FirstPersonShooterActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
            }
        }
    }
    public FirstPersonShooterActions @FirstPersonShooter => new FirstPersonShooterActions(this);

    // FirstPersonCamera
    private readonly InputActionMap m_FirstPersonCamera;
    private IFirstPersonCameraActions m_FirstPersonCameraActionsCallbackInterface;
    private readonly InputAction m_FirstPersonCamera_Anim;
    public struct FirstPersonCameraActions
    {
        private @PlayerInputAction m_Wrapper;
        public FirstPersonCameraActions(@PlayerInputAction wrapper) { m_Wrapper = wrapper; }
        public InputAction @Anim => m_Wrapper.m_FirstPersonCamera_Anim;
        public InputActionMap Get() { return m_Wrapper.m_FirstPersonCamera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FirstPersonCameraActions set) { return set.Get(); }
        public void SetCallbacks(IFirstPersonCameraActions instance)
        {
            if (m_Wrapper.m_FirstPersonCameraActionsCallbackInterface != null)
            {
                @Anim.started -= m_Wrapper.m_FirstPersonCameraActionsCallbackInterface.OnAnim;
                @Anim.performed -= m_Wrapper.m_FirstPersonCameraActionsCallbackInterface.OnAnim;
                @Anim.canceled -= m_Wrapper.m_FirstPersonCameraActionsCallbackInterface.OnAnim;
            }
            m_Wrapper.m_FirstPersonCameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Anim.started += instance.OnAnim;
                @Anim.performed += instance.OnAnim;
                @Anim.canceled += instance.OnAnim;
            }
        }
    }
    public FirstPersonCameraActions @FirstPersonCamera => new FirstPersonCameraActions(this);
    public interface IFirstPersonShooterActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
    }
    public interface IFirstPersonCameraActions
    {
        void OnAnim(InputAction.CallbackContext context);
    }
}
