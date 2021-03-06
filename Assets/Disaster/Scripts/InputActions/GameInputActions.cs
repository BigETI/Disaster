// GENERATED AUTOMATICALLY FROM 'Assets/Disaster/InputActions/GameInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Disaster.InputActions
{
    public class @GameInputActions : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @GameInputActions()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInputActions"",
    ""maps"": [
        {
            ""name"": ""GameActionMap"",
            ""id"": ""c3282cce-54e9-49a1-a2b9-484c088bfb74"",
            ""actions"": [
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""ceffb010-a107-4de2-a99f-2f783ca27f1d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""9f79e8b7-041f-48e7-99cd-f3bc83d20dd6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""313b8ae9-a4e6-434a-a534-bf5704a762bc"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8c68db74-a06d-442f-8345-c222cb3011fd"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Reload"",
                    ""type"": ""Button"",
                    ""id"": ""d83ca07b-2996-49ed-bc4f-6d848190e1ca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SelectLastWeapon"",
                    ""type"": ""Button"",
                    ""id"": ""37d4166a-138d-4a27-b7ad-25e0b91652ac"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SelectWeapon"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d85aebc6-ac4f-4ea0-b1f7-8e77d54b8826"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""342278cb-ea47-42b2-b766-3e5e20815531"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sneak"",
                    ""type"": ""Button"",
                    ""id"": ""b3c0a30b-6f39-47cd-bcb3-9894c75dec18"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""9d5b256e-1b47-4aff-8bbf-ab36b4f9e786"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwitchView"",
                    ""type"": ""Button"",
                    ""id"": ""b708d9a0-eddd-4462-b8b5-2184ff010cf7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""068ee17a-12bb-4f96-a879-8366f0980265"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASDKeys"",
                    ""id"": ""a29018fe-060b-46ae-8216-2b9785b60813"",
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
                    ""id"": ""05062532-92e6-460d-af4f-65d49d9cfbaf"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""96de8237-5c29-4118-ade1-3ff31d9bd842"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7a43f27a-4d94-4ffc-9362-c468353d7796"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ba722e60-c2a4-42bb-9400-6054ffee7436"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""eee392d3-e2be-4e6c-b041-e08f1775fdaa"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""021e5ab4-6b01-4135-9efb-594bd99bb0b2"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7cf2bdc3-bee3-44c9-a928-4d1e11a3697b"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""31a7a07b-f2fd-402d-bf18-aadb17ea0c5c"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""528938b3-5c4a-4307-bb00-9a6aaf9ab21a"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""136a4604-32d5-4187-b1da-79ea182d7484"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""09ca7287-2ea7-4e99-afa2-e0722d29430b"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""InvertVector2(invertX=false)"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""75218734-8b2e-4e12-9d4a-eb89e0617005"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=0.25,y=-0.25)"",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""LeftAndRightShoulderButtons"",
                    ""id"": ""8e6ee9d2-c2ff-4359-b19c-84edc6b004be"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SelectWeapon"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b12edc9c-f728-4558-8c38-cde4089c27b4"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""SelectWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8b00de62-194f-4340-89ee-224d7d9a54d6"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""SelectWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3544246b-afe7-4c12-8c42-6f8ec96913ce"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""SelectWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d8d8e497-99e0-42ef-bd96-cffcbad77f8b"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""SelectLastWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8979a3b1-1af9-4406-be5c-48a0fadf63a5"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""SelectLastWeapon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""39a56ac1-ea6c-4070-82c6-41e6349059ac"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Sneak"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""40a49d09-1bba-488b-8f3c-442d604c2e45"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Sneak"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb059089-264c-4923-b829-0e2c8300adb4"",
                    ""path"": ""<Gamepad>/rightStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""SwitchView"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1dd79518-e234-4864-a0fd-5f00a84c2d58"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""SwitchView"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""edfe1706-5437-49c0-ba35-bf8e5d248174"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""09c6de74-fbe1-43d3-a19a-387279f08d2d"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Reload"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cb4a0e3e-ee09-48c8-9fd3-f0a438ddb758"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8eaba957-a4be-4b45-b91a-89d420cb2bb5"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and mouse"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard and mouse"",
            ""bindingGroup"": ""Keyboard and mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // GameActionMap
            m_GameActionMap = asset.FindActionMap("GameActionMap", throwIfNotFound: true);
            m_GameActionMap_Interact = m_GameActionMap.FindAction("Interact", throwIfNotFound: true);
            m_GameActionMap_Jump = m_GameActionMap.FindAction("Jump", throwIfNotFound: true);
            m_GameActionMap_Look = m_GameActionMap.FindAction("Look", throwIfNotFound: true);
            m_GameActionMap_Move = m_GameActionMap.FindAction("Move", throwIfNotFound: true);
            m_GameActionMap_Reload = m_GameActionMap.FindAction("Reload", throwIfNotFound: true);
            m_GameActionMap_SelectLastWeapon = m_GameActionMap.FindAction("SelectLastWeapon", throwIfNotFound: true);
            m_GameActionMap_SelectWeapon = m_GameActionMap.FindAction("SelectWeapon", throwIfNotFound: true);
            m_GameActionMap_Shoot = m_GameActionMap.FindAction("Shoot", throwIfNotFound: true);
            m_GameActionMap_Sneak = m_GameActionMap.FindAction("Sneak", throwIfNotFound: true);
            m_GameActionMap_Sprint = m_GameActionMap.FindAction("Sprint", throwIfNotFound: true);
            m_GameActionMap_SwitchView = m_GameActionMap.FindAction("SwitchView", throwIfNotFound: true);
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

        // GameActionMap
        private readonly InputActionMap m_GameActionMap;
        private IGameActionMapActions m_GameActionMapActionsCallbackInterface;
        private readonly InputAction m_GameActionMap_Interact;
        private readonly InputAction m_GameActionMap_Jump;
        private readonly InputAction m_GameActionMap_Look;
        private readonly InputAction m_GameActionMap_Move;
        private readonly InputAction m_GameActionMap_Reload;
        private readonly InputAction m_GameActionMap_SelectLastWeapon;
        private readonly InputAction m_GameActionMap_SelectWeapon;
        private readonly InputAction m_GameActionMap_Shoot;
        private readonly InputAction m_GameActionMap_Sneak;
        private readonly InputAction m_GameActionMap_Sprint;
        private readonly InputAction m_GameActionMap_SwitchView;
        public struct GameActionMapActions
        {
            private @GameInputActions m_Wrapper;
            public GameActionMapActions(@GameInputActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Interact => m_Wrapper.m_GameActionMap_Interact;
            public InputAction @Jump => m_Wrapper.m_GameActionMap_Jump;
            public InputAction @Look => m_Wrapper.m_GameActionMap_Look;
            public InputAction @Move => m_Wrapper.m_GameActionMap_Move;
            public InputAction @Reload => m_Wrapper.m_GameActionMap_Reload;
            public InputAction @SelectLastWeapon => m_Wrapper.m_GameActionMap_SelectLastWeapon;
            public InputAction @SelectWeapon => m_Wrapper.m_GameActionMap_SelectWeapon;
            public InputAction @Shoot => m_Wrapper.m_GameActionMap_Shoot;
            public InputAction @Sneak => m_Wrapper.m_GameActionMap_Sneak;
            public InputAction @Sprint => m_Wrapper.m_GameActionMap_Sprint;
            public InputAction @SwitchView => m_Wrapper.m_GameActionMap_SwitchView;
            public InputActionMap Get() { return m_Wrapper.m_GameActionMap; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(GameActionMapActions set) { return set.Get(); }
            public void SetCallbacks(IGameActionMapActions instance)
            {
                if (m_Wrapper.m_GameActionMapActionsCallbackInterface != null)
                {
                    @Interact.started -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnInteract;
                    @Interact.performed -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnInteract;
                    @Interact.canceled -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnInteract;
                    @Jump.started -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnJump;
                    @Jump.performed -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnJump;
                    @Jump.canceled -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnJump;
                    @Look.started -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnLook;
                    @Look.performed -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnLook;
                    @Look.canceled -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnLook;
                    @Move.started -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnMove;
                    @Reload.started -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnReload;
                    @Reload.performed -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnReload;
                    @Reload.canceled -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnReload;
                    @SelectLastWeapon.started -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnSelectLastWeapon;
                    @SelectLastWeapon.performed -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnSelectLastWeapon;
                    @SelectLastWeapon.canceled -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnSelectLastWeapon;
                    @SelectWeapon.started -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnSelectWeapon;
                    @SelectWeapon.performed -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnSelectWeapon;
                    @SelectWeapon.canceled -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnSelectWeapon;
                    @Shoot.started -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnShoot;
                    @Shoot.performed -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnShoot;
                    @Shoot.canceled -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnShoot;
                    @Sneak.started -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnSneak;
                    @Sneak.performed -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnSneak;
                    @Sneak.canceled -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnSneak;
                    @Sprint.started -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnSprint;
                    @Sprint.performed -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnSprint;
                    @Sprint.canceled -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnSprint;
                    @SwitchView.started -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnSwitchView;
                    @SwitchView.performed -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnSwitchView;
                    @SwitchView.canceled -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnSwitchView;
                }
                m_Wrapper.m_GameActionMapActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Interact.started += instance.OnInteract;
                    @Interact.performed += instance.OnInteract;
                    @Interact.canceled += instance.OnInteract;
                    @Jump.started += instance.OnJump;
                    @Jump.performed += instance.OnJump;
                    @Jump.canceled += instance.OnJump;
                    @Look.started += instance.OnLook;
                    @Look.performed += instance.OnLook;
                    @Look.canceled += instance.OnLook;
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                    @Reload.started += instance.OnReload;
                    @Reload.performed += instance.OnReload;
                    @Reload.canceled += instance.OnReload;
                    @SelectLastWeapon.started += instance.OnSelectLastWeapon;
                    @SelectLastWeapon.performed += instance.OnSelectLastWeapon;
                    @SelectLastWeapon.canceled += instance.OnSelectLastWeapon;
                    @SelectWeapon.started += instance.OnSelectWeapon;
                    @SelectWeapon.performed += instance.OnSelectWeapon;
                    @SelectWeapon.canceled += instance.OnSelectWeapon;
                    @Shoot.started += instance.OnShoot;
                    @Shoot.performed += instance.OnShoot;
                    @Shoot.canceled += instance.OnShoot;
                    @Sneak.started += instance.OnSneak;
                    @Sneak.performed += instance.OnSneak;
                    @Sneak.canceled += instance.OnSneak;
                    @Sprint.started += instance.OnSprint;
                    @Sprint.performed += instance.OnSprint;
                    @Sprint.canceled += instance.OnSprint;
                    @SwitchView.started += instance.OnSwitchView;
                    @SwitchView.performed += instance.OnSwitchView;
                    @SwitchView.canceled += instance.OnSwitchView;
                }
            }
        }
        public GameActionMapActions @GameActionMap => new GameActionMapActions(this);
        private int m_GamepadSchemeIndex = -1;
        public InputControlScheme GamepadScheme
        {
            get
            {
                if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
                return asset.controlSchemes[m_GamepadSchemeIndex];
            }
        }
        private int m_KeyboardandmouseSchemeIndex = -1;
        public InputControlScheme KeyboardandmouseScheme
        {
            get
            {
                if (m_KeyboardandmouseSchemeIndex == -1) m_KeyboardandmouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and mouse");
                return asset.controlSchemes[m_KeyboardandmouseSchemeIndex];
            }
        }
        public interface IGameActionMapActions
        {
            void OnInteract(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
            void OnLook(InputAction.CallbackContext context);
            void OnMove(InputAction.CallbackContext context);
            void OnReload(InputAction.CallbackContext context);
            void OnSelectLastWeapon(InputAction.CallbackContext context);
            void OnSelectWeapon(InputAction.CallbackContext context);
            void OnShoot(InputAction.CallbackContext context);
            void OnSneak(InputAction.CallbackContext context);
            void OnSprint(InputAction.CallbackContext context);
            void OnSwitchView(InputAction.CallbackContext context);
        }
    }
}
