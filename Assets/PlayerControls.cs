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
                }
            ]
        },
        {
            ""name"": ""PlayMusic"",
            ""id"": ""ff7fb08e-b75d-4e5f-bd16-965ca2490abf"",
            ""actions"": [
                {
                    ""name"": ""Prev"",
                    ""type"": ""Button"",
                    ""id"": ""b4db03d3-a05d-412f-b55f-5ed814848625"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Next"",
                    ""type"": ""Button"",
                    ""id"": ""6bdc87ad-0115-456a-bab3-17df9356a93b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""VolUp"",
                    ""type"": ""Button"",
                    ""id"": ""2c2132a2-73b6-4fff-8120-c9e7c2708e3e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""VolDown"",
                    ""type"": ""Button"",
                    ""id"": ""e3062f06-ba38-4071-adf8-acdfdd08bcdc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PlayPause"",
                    ""type"": ""Button"",
                    ""id"": ""43c64c74-3339-407b-a967-3f000bb583e3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShuffleOnOff"",
                    ""type"": ""Button"",
                    ""id"": ""f127571a-1cac-4315-bb72-45b98d88cb09"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""83ff70d6-5b5c-4973-b69b-fd1e06106e03"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Prev"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""51f42958-6c1e-4bd4-ab05-eb9d6dc36571"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Prev"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b7c28e6d-68dc-4534-9b1f-6af96b0bfc3d"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Next"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6574f4b5-b8c8-4379-9b81-0423ccf28b13"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Next"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d8330f72-557e-4229-adaf-1107b5264f38"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VolUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ae3e15d3-6de8-429b-8ba0-9aba87bd3549"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VolUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ec412568-8273-4887-8fc0-69b822af58c1"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VolDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c30133cc-b1cf-45ad-b593-46e5b6f9f2c4"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""VolDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c297944-3904-4a9b-871c-39caf3f3552f"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayPause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cdd275e0-bc2b-42fe-9b32-a178af8e7ab9"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ShuffleOnOff"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
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
        // PlayMusic
        m_PlayMusic = asset.FindActionMap("PlayMusic", throwIfNotFound: true);
        m_PlayMusic_Prev = m_PlayMusic.FindAction("Prev", throwIfNotFound: true);
        m_PlayMusic_Next = m_PlayMusic.FindAction("Next", throwIfNotFound: true);
        m_PlayMusic_VolUp = m_PlayMusic.FindAction("VolUp", throwIfNotFound: true);
        m_PlayMusic_VolDown = m_PlayMusic.FindAction("VolDown", throwIfNotFound: true);
        m_PlayMusic_PlayPause = m_PlayMusic.FindAction("PlayPause", throwIfNotFound: true);
        m_PlayMusic_ShuffleOnOff = m_PlayMusic.FindAction("ShuffleOnOff", throwIfNotFound: true);
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

    // PlayMusic
    private readonly InputActionMap m_PlayMusic;
    private IPlayMusicActions m_PlayMusicActionsCallbackInterface;
    private readonly InputAction m_PlayMusic_Prev;
    private readonly InputAction m_PlayMusic_Next;
    private readonly InputAction m_PlayMusic_VolUp;
    private readonly InputAction m_PlayMusic_VolDown;
    private readonly InputAction m_PlayMusic_PlayPause;
    private readonly InputAction m_PlayMusic_ShuffleOnOff;
    public struct PlayMusicActions
    {
        private @PlayerControls m_Wrapper;
        public PlayMusicActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Prev => m_Wrapper.m_PlayMusic_Prev;
        public InputAction @Next => m_Wrapper.m_PlayMusic_Next;
        public InputAction @VolUp => m_Wrapper.m_PlayMusic_VolUp;
        public InputAction @VolDown => m_Wrapper.m_PlayMusic_VolDown;
        public InputAction @PlayPause => m_Wrapper.m_PlayMusic_PlayPause;
        public InputAction @ShuffleOnOff => m_Wrapper.m_PlayMusic_ShuffleOnOff;
        public InputActionMap Get() { return m_Wrapper.m_PlayMusic; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayMusicActions set) { return set.Get(); }
        public void SetCallbacks(IPlayMusicActions instance)
        {
            if (m_Wrapper.m_PlayMusicActionsCallbackInterface != null)
            {
                @Prev.started -= m_Wrapper.m_PlayMusicActionsCallbackInterface.OnPrev;
                @Prev.performed -= m_Wrapper.m_PlayMusicActionsCallbackInterface.OnPrev;
                @Prev.canceled -= m_Wrapper.m_PlayMusicActionsCallbackInterface.OnPrev;
                @Next.started -= m_Wrapper.m_PlayMusicActionsCallbackInterface.OnNext;
                @Next.performed -= m_Wrapper.m_PlayMusicActionsCallbackInterface.OnNext;
                @Next.canceled -= m_Wrapper.m_PlayMusicActionsCallbackInterface.OnNext;
                @VolUp.started -= m_Wrapper.m_PlayMusicActionsCallbackInterface.OnVolUp;
                @VolUp.performed -= m_Wrapper.m_PlayMusicActionsCallbackInterface.OnVolUp;
                @VolUp.canceled -= m_Wrapper.m_PlayMusicActionsCallbackInterface.OnVolUp;
                @VolDown.started -= m_Wrapper.m_PlayMusicActionsCallbackInterface.OnVolDown;
                @VolDown.performed -= m_Wrapper.m_PlayMusicActionsCallbackInterface.OnVolDown;
                @VolDown.canceled -= m_Wrapper.m_PlayMusicActionsCallbackInterface.OnVolDown;
                @PlayPause.started -= m_Wrapper.m_PlayMusicActionsCallbackInterface.OnPlayPause;
                @PlayPause.performed -= m_Wrapper.m_PlayMusicActionsCallbackInterface.OnPlayPause;
                @PlayPause.canceled -= m_Wrapper.m_PlayMusicActionsCallbackInterface.OnPlayPause;
                @ShuffleOnOff.started -= m_Wrapper.m_PlayMusicActionsCallbackInterface.OnShuffleOnOff;
                @ShuffleOnOff.performed -= m_Wrapper.m_PlayMusicActionsCallbackInterface.OnShuffleOnOff;
                @ShuffleOnOff.canceled -= m_Wrapper.m_PlayMusicActionsCallbackInterface.OnShuffleOnOff;
            }
            m_Wrapper.m_PlayMusicActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Prev.started += instance.OnPrev;
                @Prev.performed += instance.OnPrev;
                @Prev.canceled += instance.OnPrev;
                @Next.started += instance.OnNext;
                @Next.performed += instance.OnNext;
                @Next.canceled += instance.OnNext;
                @VolUp.started += instance.OnVolUp;
                @VolUp.performed += instance.OnVolUp;
                @VolUp.canceled += instance.OnVolUp;
                @VolDown.started += instance.OnVolDown;
                @VolDown.performed += instance.OnVolDown;
                @VolDown.canceled += instance.OnVolDown;
                @PlayPause.started += instance.OnPlayPause;
                @PlayPause.performed += instance.OnPlayPause;
                @PlayPause.canceled += instance.OnPlayPause;
                @ShuffleOnOff.started += instance.OnShuffleOnOff;
                @ShuffleOnOff.performed += instance.OnShuffleOnOff;
                @ShuffleOnOff.canceled += instance.OnShuffleOnOff;
            }
        }
    }
    public PlayMusicActions @PlayMusic => new PlayMusicActions(this);
    public interface ILookAroundActions
    {
        void OnRotation(InputAction.CallbackContext context);
    }
    public interface IWalkAroundActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
    public interface IPlayMusicActions
    {
        void OnPrev(InputAction.CallbackContext context);
        void OnNext(InputAction.CallbackContext context);
        void OnVolUp(InputAction.CallbackContext context);
        void OnVolDown(InputAction.CallbackContext context);
        void OnPlayPause(InputAction.CallbackContext context);
        void OnShuffleOnOff(InputAction.CallbackContext context);
    }
}
