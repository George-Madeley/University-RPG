// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace UniRPG.Controls
{
    public class @Controls : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @Controls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Inventory"",
            ""id"": ""74e86c80-342a-4761-9e37-23feeec66f61"",
            ""actions"": [
                {
                    ""name"": ""ToggleInventory"",
                    ""type"": ""Button"",
                    ""id"": ""4a4c9389-7d1e-4ed4-80f4-0362a995d55f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7f3f7d82-fa32-41e0-b206-29e4a17a95ca"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controls"",
                    ""action"": ""ToggleInventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player"",
            ""id"": ""12bcf2dc-492d-4b7a-924c-9107eb4065f3"",
            ""actions"": [
                {
                    ""name"": ""WalkHorizontal"",
                    ""type"": ""Button"",
                    ""id"": ""b67672f4-f8a0-4bd6-b121-4ce0e8f9ca68"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""WalkVertical"",
                    ""type"": ""Button"",
                    ""id"": ""44ae6c28-1750-4273-81e6-246b006885bc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""AD"",
                    ""id"": ""53d3d711-a5d9-46a0-b836-d685388162f2"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WalkHorizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4edad6ba-c153-434c-9c4a-d9d9c28d0cd1"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controls"",
                    ""action"": ""WalkHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""33add524-d284-4974-8184-89ff0ae0a85d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controls"",
                    ""action"": ""WalkHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""a8dc8a28-11e8-451a-8ee6-ccc9e968f4d1"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WalkHorizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""6d71737f-736e-4f0e-805d-8739dc57f246"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controls"",
                    ""action"": ""WalkHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""05fa6c25-c642-48e6-af74-fa43492b7c4f"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controls"",
                    ""action"": ""WalkHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WS"",
                    ""id"": ""e47b994f-6593-444c-9587-4edb2fe251a4"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WalkVertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c6db0df0-5d57-446f-a13a-b25f7a24b6ef"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controls"",
                    ""action"": ""WalkVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1ee0373a-2487-4986-94eb-095569d0fe70"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controls"",
                    ""action"": ""WalkVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""e2fd3591-1e76-459d-99d1-30caa4b83eb0"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WalkVertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""21bfd127-6813-4b24-9954-0fc802e97039"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controls"",
                    ""action"": ""WalkVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""bcc5dcb6-b4f5-4a32-9e10-a8791f16ac29"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controls"",
                    ""action"": ""WalkVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Controls"",
            ""bindingGroup"": ""Controls"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // Inventory
            m_Inventory = asset.FindActionMap("Inventory", throwIfNotFound: true);
            m_Inventory_ToggleInventory = m_Inventory.FindAction("ToggleInventory", throwIfNotFound: true);
            // Player
            m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
            m_Player_WalkHorizontal = m_Player.FindAction("WalkHorizontal", throwIfNotFound: true);
            m_Player_WalkVertical = m_Player.FindAction("WalkVertical", throwIfNotFound: true);
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

        // Inventory
        private readonly InputActionMap m_Inventory;
        private IInventoryActions m_InventoryActionsCallbackInterface;
        private readonly InputAction m_Inventory_ToggleInventory;
        public struct InventoryActions
        {
            private @Controls m_Wrapper;
            public InventoryActions(@Controls wrapper) { m_Wrapper = wrapper; }
            public InputAction @ToggleInventory => m_Wrapper.m_Inventory_ToggleInventory;
            public InputActionMap Get() { return m_Wrapper.m_Inventory; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(InventoryActions set) { return set.Get(); }
            public void SetCallbacks(IInventoryActions instance)
            {
                if (m_Wrapper.m_InventoryActionsCallbackInterface != null)
                {
                    @ToggleInventory.started -= m_Wrapper.m_InventoryActionsCallbackInterface.OnToggleInventory;
                    @ToggleInventory.performed -= m_Wrapper.m_InventoryActionsCallbackInterface.OnToggleInventory;
                    @ToggleInventory.canceled -= m_Wrapper.m_InventoryActionsCallbackInterface.OnToggleInventory;
                }
                m_Wrapper.m_InventoryActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @ToggleInventory.started += instance.OnToggleInventory;
                    @ToggleInventory.performed += instance.OnToggleInventory;
                    @ToggleInventory.canceled += instance.OnToggleInventory;
                }
            }
        }
        public InventoryActions @Inventory => new InventoryActions(this);

        // Player
        private readonly InputActionMap m_Player;
        private IPlayerActions m_PlayerActionsCallbackInterface;
        private readonly InputAction m_Player_WalkHorizontal;
        private readonly InputAction m_Player_WalkVertical;
        public struct PlayerActions
        {
            private @Controls m_Wrapper;
            public PlayerActions(@Controls wrapper) { m_Wrapper = wrapper; }
            public InputAction @WalkHorizontal => m_Wrapper.m_Player_WalkHorizontal;
            public InputAction @WalkVertical => m_Wrapper.m_Player_WalkVertical;
            public InputActionMap Get() { return m_Wrapper.m_Player; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerActions instance)
            {
                if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
                {
                    @WalkHorizontal.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWalkHorizontal;
                    @WalkHorizontal.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWalkHorizontal;
                    @WalkHorizontal.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWalkHorizontal;
                    @WalkVertical.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWalkVertical;
                    @WalkVertical.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWalkVertical;
                    @WalkVertical.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWalkVertical;
                }
                m_Wrapper.m_PlayerActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @WalkHorizontal.started += instance.OnWalkHorizontal;
                    @WalkHorizontal.performed += instance.OnWalkHorizontal;
                    @WalkHorizontal.canceled += instance.OnWalkHorizontal;
                    @WalkVertical.started += instance.OnWalkVertical;
                    @WalkVertical.performed += instance.OnWalkVertical;
                    @WalkVertical.canceled += instance.OnWalkVertical;
                }
            }
        }
        public PlayerActions @Player => new PlayerActions(this);
        private int m_ControlsSchemeIndex = -1;
        public InputControlScheme ControlsScheme
        {
            get
            {
                if (m_ControlsSchemeIndex == -1) m_ControlsSchemeIndex = asset.FindControlSchemeIndex("Controls");
                return asset.controlSchemes[m_ControlsSchemeIndex];
            }
        }
        public interface IInventoryActions
        {
            void OnToggleInventory(InputAction.CallbackContext context);
        }
        public interface IPlayerActions
        {
            void OnWalkHorizontal(InputAction.CallbackContext context);
            void OnWalkVertical(InputAction.CallbackContext context);
        }
    }
}
