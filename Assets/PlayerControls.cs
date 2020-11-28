// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""LookAround"",
            ""id"": ""f908acaf-5e8f-4179-b64e-cb19b87f31e8"",
            ""actions"": [
                {
                    ""name"": ""Rotation"",
                    ""type"": ""Value"",
                    ""id"": ""f311a90f-3dda-4e44-b520-7be97be5df5f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""84284a59-23c1-49c3-87aa-2450d25d9138"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e233d90d-0d3e-4001-b72f-e79aa2fe455a"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""WalkAround"",
            ""id"": ""600cd020-ca06-4e92-930f-19c9d910db80"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""36812b26-a4ae-47e0-b67e-2c6c407a029e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""68694cb5-b288-400c-9907-b6a8d8a4a797"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""225368a8-5a37-43f5-995b-86cd60e577bd"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""497f7b4b-df38-4f4a-b567-47421cc873b3"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7b187316-3088-46ff-abed-f837736d01cf"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9306efc8-747c-4fd3-8cc6-5cbf7edbec05"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f2cd6ebb-f495-457e-9bce-8cd2569bc57c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ArrowKeys"",
                    ""id"": ""36c86c79-a5f8-437b-918a-f70cd8af967b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""007e005f-55fc-4131-8226-992e2a291f7d"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f6ecc8ee-0afd-4e3a-ba88-989137f8eb37"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""47644295-303f-42c1-9557-c28e2cf50e7e"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2475eedc-15c4-4f2c-865f-d6cb918f3a01"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Dpad"",
                    ""id"": ""85458019-8b51-4abb-89cd-d77ea45fe31c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""28699f11-af4e-45d7-b37b-35234ff3ae6a"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4cb0aa90-3ea5-43b5-94bd-2f5738a95fe6"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6ed03d81-6d9d-411d-aa41-af4d3d8e9891"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""0083bb9c-0a0a-46fe-99f9-b49be2b78ebb"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // LookAround
        m_LookAround = asset.FindActionMap("LookAround", throwIfNotFound: true);
        m_LookAround_Rotation = m_LookAround.FindAction("Rotation", throwIfNotFound: true);
        // WalkAround
        m_WalkAround = asset.FindActionMap("WalkAround", throwIfNotFound: true);
        m_WalkAround_Movement = m_WalkAround.FindAction("Movement", throwIfNotFound: true);
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

    // LookAround
    private readonly InputActionMap m_LookAround;
    private ILookAroundActions m_LookAroundActionsCallbackInterface;
    private readonly InputAction m_LookAround_Rotation;
    public struct LookAroundActions
    {
        private @PlayerControls m_Wrapper;
        public LookAroundActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rotation => m_Wrapper.m_LookAround_Rotation;
        public InputActionMap Get() { return m_Wrapper.m_LookAround; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LookAroundActions set) { return set.Get(); }
        public void SetCallbacks(ILookAroundActions instance)
        {
            if (m_Wrapper.m_LookAroundActionsCallbackInterface != null)
            {
                @Rotation.started -= m_Wrapper.m_LookAroundActionsCallbackInterface.OnRotation;
                @Rotation.performed -= m_Wrapper.m_LookAroundActionsCallbackInterface.OnRotation;
                @Rotation.canceled -= m_Wrapper.m_LookAroundActionsCallbackInterface.OnRotation;
            }
            m_Wrapper.m_LookAroundActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Rotation.started += instance.OnRotation;
                @Rotation.performed += instance.OnRotation;
                @Rotation.canceled += instance.OnRotation;
            }
        }
    }
    public LookAroundActions @LookAround => new LookAroundActions(this);

    // WalkAround
    private readonly InputActionMap m_WalkAround;
    private IWalkAroundActions m_WalkAroundActionsCallbackInterface;
    private readonly InputAction m_WalkAround_Movement;
    public struct WalkAroundActions
    {
        private @PlayerControls m_Wrapper;
        public WalkAroundActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_WalkAround_Movement;
        public InputActionMap Get() { return m_Wrapper.m_WalkAround; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(WalkAroundActions set) { return set.Get(); }
        public void SetCallbacks(IWalkAroundActions instance)
        {
            if (m_Wrapper.m_WalkAroundActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_WalkAroundActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_WalkAroundActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_WalkAroundActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_WalkAroundActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
            }
        }
    }
    public WalkAroundActions @WalkAround => new WalkAroundActions(this);
    public interface ILookAroundActions
    {
        void OnRotation(InputAction.CallbackContext context);
    }
    public interface IWalkAroundActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
}
