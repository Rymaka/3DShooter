// GENERATED AUTOMATICALLY FROM 'Assets/HurricaneVR/Framework/Scripts/ControllerInput/InputSystem/HVRInputActions.inputactions'

#if ENABLE_INPUT_SYSTEM
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @HVRInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @HVRInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""HVRInputActions"",
    ""maps"": [
        {
            ""name"": ""LeftHand"",
            ""id"": ""272f6d14-89ba-496f-b7ff-215263d3219f"",
            ""actions"": [
                {
                    ""name"": ""TriggerPress"",
                    ""type"": ""Button"",
                    ""id"": ""578a0cd6-f388-4fa3-92f3-c09338bdf6fc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Trigger"",
                    ""type"": ""Value"",
                    ""id"": ""5c8cf249-a01c-4b19-8eea-152b951f6a5a"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PrimaryButton"",
                    ""type"": ""Button"",
                    ""id"": ""204073bf-582e-48f4-a392-6eaf1e637387"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PrimaryTouch"",
                    ""type"": ""Button"",
                    ""id"": ""48a4f982-c501-412c-a715-b9201cb08c37"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""e91ffee7-ec69-40fb-8663-4ebf07153bfe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Primary2DAxis"",
                    ""type"": ""Value"",
                    ""id"": ""0e72db49-759e-4b56-853f-a5e3b9bf0e04"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Primary2DAxisClick"",
                    ""type"": ""Button"",
                    ""id"": ""d36e4b01-3a25-4dc6-8094-179ddb10bd71"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Primary2DAxisTouch"",
                    ""type"": ""Button"",
                    ""id"": ""416d6df4-7244-4b5c-986c-11881e0eac57"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Secondary2DAxis"",
                    ""type"": ""Value"",
                    ""id"": ""344eec1c-660f-4d4a-8b5b-1a2362d9b2de"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Secondary2DAxisClick"",
                    ""type"": ""Button"",
                    ""id"": ""927e0cfe-b2ed-4a00-8048-3cd36742a8e3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Secondary2DAxisTouch"",
                    ""type"": ""Button"",
                    ""id"": ""28bf5850-459e-4b46-af7a-24a5a64fdf99"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Grip"",
                    ""type"": ""Value"",
                    ""id"": ""26a9b492-9ead-4e86-9484-d69dc44c512e"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GripPress"",
                    ""type"": ""Button"",
                    ""id"": ""e91897d7-06ef-41b9-aaa2-b14ae7540fca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GripForce"",
                    ""type"": ""Value"",
                    ""id"": ""36b1a84c-21c8-4826-8ecc-bfd5fea14c7b"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SecondaryButton"",
                    ""type"": ""Button"",
                    ""id"": ""1414e4ef-05d7-40b1-b759-aa2c2c9cee56"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SecondaryTouch"",
                    ""type"": ""Button"",
                    ""id"": ""83a06fa6-147b-41c5-9841-1fd2bbb33c31"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TriggerTouch"",
                    ""type"": ""Button"",
                    ""id"": ""a2c3edea-193d-4944-91ba-2e2630b711d2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ControllerPosition"",
                    ""type"": ""Value"",
                    ""id"": ""4ac0bda8-e0c1-4d35-9125-d1a86167ce4c"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ControllerRotation"",
                    ""type"": ""Value"",
                    ""id"": ""5c60ec11-4989-4ca5-8c81-a31ee8afad7f"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Haptics"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c2bd3cd6-8deb-46c4-95a9-93eaa08c44b3"",
                    ""expectedControlType"": ""Haptic"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b9c19907-3b5c-4207-ad18-5a86655f688c"",
                    ""path"": ""<XRController>{LeftHand}/{triggerButton}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TriggerPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ec353a5a-6a7a-4ee6-a33e-d12a8c0b705a"",
                    ""path"": ""<XRController>{LeftHand}/{trigger}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a98fe1d-5477-4473-9ed1-05d2decb2c15"",
                    ""path"": ""<XRController>{LeftHand}/{primaryButton}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3dfde460-9bef-4bd9-943d-170adc171ff8"",
                    ""path"": ""<XRController>{LeftHand}/{primaryTouch}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9603ae96-fef3-432c-88a0-282232c1368d"",
                    ""path"": ""<XRController>{LeftHand}/{menu}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6f261d50-7cf3-4d07-9fe5-f57d21751d4d"",
                    ""path"": ""<ViveController>{LeftHand}/menu"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""54ac7ab0-8ca9-4cbc-a6d1-da5ee0b055cb"",
                    ""path"": ""<XRController>{LeftHand}/{primary2DAxis}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Primary2DAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""85d45408-e658-4df8-ab60-de9273ceb30c"",
                    ""path"": ""<XRController>{LeftHand}/{primary2DAxisClick}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Primary2DAxisClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a07f0bb7-9d68-4288-b0f1-78c62a995fa4"",
                    ""path"": ""<XRController>{LeftHand}/{primary2DAxisTouch}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Primary2DAxisTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cb03eabc-18e2-447a-a308-dc36cf9ec38e"",
                    ""path"": ""<XRController>{LeftHand}/{secondary2DAxis}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Secondary2DAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d8e6dbb2-9e0e-453c-aaa5-5967f2fab6f6"",
                    ""path"": ""<ViveController>{LeftHand}/trackpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR Usage"",
                    ""action"": ""Secondary2DAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fadeed58-e6fc-4cc4-9fdc-5cfae044209c"",
                    ""path"": ""<XRController>{LeftHand}/{secondary2DAxisClick}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Secondary2DAxisClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""366ac51f-3093-4ead-8dba-662fe2cbb81f"",
                    ""path"": ""<ViveController>{LeftHand}/trackpadClicked"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR Usage"",
                    ""action"": ""Secondary2DAxisClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b74594f8-e87a-43ae-82ec-47612e07bfb3"",
                    ""path"": ""<XRController>{LeftHand}/{secondary2DAxisTouch}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Secondary2DAxisTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""72eeb177-b210-4a4a-8a29-1db62419451d"",
                    ""path"": ""<ViveController>{LeftHand}/trackpadTouched"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR Usage"",
                    ""action"": ""Secondary2DAxisTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""26245d74-dc1a-4fce-a7e1-1d4688ef73b1"",
                    ""path"": ""<XRController>{LeftHand}/{grip}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""42d65f44-8e82-44cd-b3c4-a5d6cea301c6"",
                    ""path"": ""<OculusTouchController>{LeftHand}/grip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1458d4ea-a188-4ad0-9215-0e48997da150"",
                    ""path"": ""<XRController>{LeftHand}/{gripButton}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GripPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0c3f7ce0-b62f-44e2-a1e1-11f143de72d7"",
                    ""path"": ""<XRController>{LeftHand}/{secondaryButton}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6cfe2a5d-28c1-425b-998e-810968e19292"",
                    ""path"": ""<XRController>{LeftHand}/{secondaryTouch}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c8114404-e28d-455e-b8a6-393da81c4ace"",
                    ""path"": ""<XRController>{LeftHand}/triggerTouched"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TriggerTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0a25f7f9-be46-4a4a-b346-a0d2c02c2817"",
                    ""path"": ""<ValveIndexController>{LeftHand}/gripForce"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR Usage"",
                    ""action"": ""GripForce"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cfa3aaa8-78b6-48e7-8002-beb9903fe613"",
                    ""path"": ""<XRController>{LeftHand}/pointerPosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR Usage"",
                    ""action"": ""ControllerPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""61b858cd-a94a-42be-b4ea-566b0502fec7"",
                    ""path"": ""<XRController>{LeftHand}/pointerRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR Usage"",
                    ""action"": ""ControllerRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e719282e-3d03-4d88-aa13-873641db842a"",
                    ""path"": ""<XRController>{LeftHand}/haptic"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR Usage"",
                    ""action"": ""Haptics"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""RightHand"",
            ""id"": ""fd87d126-5dc2-445c-82df-1abc6c9f8076"",
            ""actions"": [
                {
                    ""name"": ""TriggerPress"",
                    ""type"": ""Button"",
                    ""id"": ""bc163c5e-01a5-48ae-83b3-87e68f24f888"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Trigger"",
                    ""type"": ""Value"",
                    ""id"": ""2fccaf18-d578-4ac9-9d0b-08db4a2e1dc7"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PrimaryButton"",
                    ""type"": ""Button"",
                    ""id"": ""b87d0657-0e2f-41f9-92ee-6c7f0b0fa4f8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PrimaryTouch"",
                    ""type"": ""Value"",
                    ""id"": ""7612bd2d-ec25-4cb7-8eb2-3a4b7704b025"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""561d782c-0eab-4674-80c5-7a8eb70cf246"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Primary2DAxis"",
                    ""type"": ""Value"",
                    ""id"": ""273526bd-c3ba-4f35-ac7a-840c1ed6ab6d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Primary2DAxisClick"",
                    ""type"": ""Button"",
                    ""id"": ""1c531107-9819-4f1f-a0e7-f11166016436"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Primary2DAxisTouch"",
                    ""type"": ""Button"",
                    ""id"": ""4de79a39-d622-4859-8f67-791365c0b780"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Secondary2DAxis"",
                    ""type"": ""Value"",
                    ""id"": ""5c85476c-f285-4a0a-8ed8-31466beae969"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Secondary2DAxisClick"",
                    ""type"": ""Button"",
                    ""id"": ""83227e26-e8f1-416e-a4a6-b70394fe5ea5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Secondary2DAxisTouch"",
                    ""type"": ""Button"",
                    ""id"": ""05c6375e-e244-427a-8e61-cd465ffa62ba"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Grip"",
                    ""type"": ""Value"",
                    ""id"": ""f17f4516-fcdf-4891-9411-fee4983cd798"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GripPress"",
                    ""type"": ""Button"",
                    ""id"": ""c20d8054-3d24-478f-8c51-5df4fec8c02a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GripForce"",
                    ""type"": ""Value"",
                    ""id"": ""0432db25-4c80-4b6f-9b2d-8986bef39507"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SecondaryButton"",
                    ""type"": ""Button"",
                    ""id"": ""cba87b5e-c43b-4c38-b5dc-320d8fbb6136"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SecondaryTouch"",
                    ""type"": ""Button"",
                    ""id"": ""b20f3aa0-32c6-486d-a9b2-4d8baca0799f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TriggerTouch"",
                    ""type"": ""Button"",
                    ""id"": ""19c8c1da-1f49-498c-8cb4-be13aab1abc5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ControllerPosition"",
                    ""type"": ""Value"",
                    ""id"": ""07b14640-88dd-4da1-9a5c-c9039894b5cc"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ControllerRotation"",
                    ""type"": ""Value"",
                    ""id"": ""5d32a867-da55-4d98-9417-50f370471336"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Haptics"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7648f0bd-f36f-42c0-ade0-e15b6c3c62fe"",
                    ""expectedControlType"": ""Haptic"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e2185573-2cbd-4af0-9d4b-e03ff8b24d8f"",
                    ""path"": ""<XRController>{RightHand}/{triggerButton}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TriggerPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d1bf452d-b059-4c1e-9c23-3be1c6be789e"",
                    ""path"": ""<XRController>{RightHand}/{trigger}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Trigger"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d09e2fdd-08b3-42eb-86c8-5c3a8f4a03c5"",
                    ""path"": ""<XRController>{RightHand}/{primaryButton}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0657f0e8-4c3b-45d4-a00b-fda175a6684d"",
                    ""path"": ""<XRController>{RightHand}/{primaryTouch}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c3d9acf1-00ab-4616-951f-ef81d04d4d58"",
                    ""path"": ""<XRController>{RightHand}/{menu}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""24b22f5b-4580-4c90-bdaa-47775335806a"",
                    ""path"": ""<ViveController>{RightHand}/menu"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR Usage"",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""488857b2-965c-486c-b24e-e21628ad2a07"",
                    ""path"": ""<XRController>{RightHand}/{primary2DAxis}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Primary2DAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""feccb40e-4fa1-488f-a2f1-f44c2b80ae37"",
                    ""path"": ""<XRController>{RightHand}/{primary2DAxisClick}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Primary2DAxisClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""62761c89-0d6d-40f1-ae88-88fa58d7ff02"",
                    ""path"": ""<XRController>{RightHand}/{primary2DAxisTouch}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Primary2DAxisTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e40a1a86-f851-421e-86c4-aec93c7f1d9b"",
                    ""path"": ""<XRController>{RightHand}/{secondary2DAxis}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Secondary2DAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""80b61ccb-82b6-4211-8ba9-e566090957b8"",
                    ""path"": ""<ViveController>{RightHand}/trackpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR Usage"",
                    ""action"": ""Secondary2DAxis"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d094a06a-f8ca-4c85-b478-a5276f7da3e4"",
                    ""path"": ""<XRController>{RightHand}/{secondary2DAxisClick}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Secondary2DAxisClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c33bf2de-0080-4d75-b40b-0d3593ac31d8"",
                    ""path"": ""<ViveController>{RightHand}/trackpadClicked"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR Usage"",
                    ""action"": ""Secondary2DAxisClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""75e038e5-ec3b-417e-adf4-77881b52a1ff"",
                    ""path"": ""<XRController>{RightHand}/{secondary2DAxisTouch}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Secondary2DAxisTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c6386f8-5725-475b-9a82-7a50899c9059"",
                    ""path"": ""<ViveController>{RightHand}/trackpadTouched"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR Usage"",
                    ""action"": ""Secondary2DAxisTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f2c3d836-9c35-4647-a506-9e03f37d837f"",
                    ""path"": ""<XRController>{RightHand}/{grip}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Grip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6f0b2479-b471-4775-8381-980b7957af20"",
                    ""path"": ""<XRController>{RightHand}/{gripButton}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GripPress"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9d0fd645-57e1-48c3-9393-701a1d96c9a2"",
                    ""path"": ""<XRController>{RightHand}/{secondaryButton}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0d034f83-a2ec-4c56-8a45-74443b36bb77"",
                    ""path"": ""<XRController>{RightHand}/{secondaryTouch}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e0c1b30a-a004-4a7b-8745-59a3b30a5008"",
                    ""path"": ""<XRController>{RightHand}/triggerTouched"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TriggerTouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e4192ed0-d0cf-4e23-9667-c97de50aa066"",
                    ""path"": ""<ValveIndexController>{RightHand}/gripForce"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR Usage"",
                    ""action"": ""GripForce"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4b8dde4f-389e-4c1c-b991-1dd5ab5a4191"",
                    ""path"": ""<XRController>{RightHand}/pointerPosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR Usage"",
                    ""action"": ""ControllerPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""02bbe9e2-867c-4358-8ce9-7aff8fd0a0c1"",
                    ""path"": ""<XRController>{RightHand}/pointerRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR Usage"",
                    ""action"": ""ControllerRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0a59792b-c32d-4272-9a42-d8bcc47580da"",
                    ""path"": ""<XRController>{RightHand}/haptic"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR Usage"",
                    ""action"": ""Haptics"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""HMD"",
            ""id"": ""21d522e0-0295-43ef-b60a-3b355794717b"",
            ""actions"": [
                {
                    ""name"": ""hmdPosition"",
                    ""type"": ""Value"",
                    ""id"": ""36a3121d-efce-478c-867c-a8d354777b78"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""hmdRotation"",
                    ""type"": ""Value"",
                    ""id"": ""4e56a29d-b0cc-42fd-a087-552950afac95"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""08f50b61-5d92-42ac-bdb9-b898a4f0d4a7"",
                    ""path"": ""<XRHMD>/centerEyePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""hmdPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""09769104-56ee-4fae-9065-07f530388e75"",
                    ""path"": ""<XRHMD>/centerEyeRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""hmdRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""a725e4f4-1262-4d6f-8a52-b8ba368d4c82"",
            ""actions"": [
                {
                    ""name"": ""Click"",
                    ""type"": ""Button"",
                    ""id"": ""7d87f920-38ab-4a79-9716-27722a02c594"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""pointerPosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3e8f3014-2311-4c71-9a89-6fffe0d7ae05"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""pointerRotation"",
                    ""type"": ""PassThrough"",
                    ""id"": ""fff59030-bd11-46a7-96d3-35f8e50a86ca"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""78d62036-f819-477f-ba34-5041450a668f"",
                    ""path"": ""<XRController>/triggerPressed"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR Usage"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fc05f8fe-0a9a-49ec-84a5-01ccef667093"",
                    ""path"": ""<XRController>/pointerPosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""pointerPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""047b05df-5df2-4fcf-81d7-a51f39906c16"",
                    ""path"": ""<XRController>/pointerRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""pointerRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""XR Usage"",
            ""bindingGroup"": ""XR Usage"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // LeftHand
        m_LeftHand = asset.FindActionMap("LeftHand", throwIfNotFound: true);
        m_LeftHand_TriggerPress = m_LeftHand.FindAction("TriggerPress", throwIfNotFound: true);
        m_LeftHand_Trigger = m_LeftHand.FindAction("Trigger", throwIfNotFound: true);
        m_LeftHand_PrimaryButton = m_LeftHand.FindAction("PrimaryButton", throwIfNotFound: true);
        m_LeftHand_PrimaryTouch = m_LeftHand.FindAction("PrimaryTouch", throwIfNotFound: true);
        m_LeftHand_Menu = m_LeftHand.FindAction("Menu", throwIfNotFound: true);
        m_LeftHand_Primary2DAxis = m_LeftHand.FindAction("Primary2DAxis", throwIfNotFound: true);
        m_LeftHand_Primary2DAxisClick = m_LeftHand.FindAction("Primary2DAxisClick", throwIfNotFound: true);
        m_LeftHand_Primary2DAxisTouch = m_LeftHand.FindAction("Primary2DAxisTouch", throwIfNotFound: true);
        m_LeftHand_Secondary2DAxis = m_LeftHand.FindAction("Secondary2DAxis", throwIfNotFound: true);
        m_LeftHand_Secondary2DAxisClick = m_LeftHand.FindAction("Secondary2DAxisClick", throwIfNotFound: true);
        m_LeftHand_Secondary2DAxisTouch = m_LeftHand.FindAction("Secondary2DAxisTouch", throwIfNotFound: true);
        m_LeftHand_Grip = m_LeftHand.FindAction("Grip", throwIfNotFound: true);
        m_LeftHand_GripPress = m_LeftHand.FindAction("GripPress", throwIfNotFound: true);
        m_LeftHand_GripForce = m_LeftHand.FindAction("GripForce", throwIfNotFound: true);
        m_LeftHand_SecondaryButton = m_LeftHand.FindAction("SecondaryButton", throwIfNotFound: true);
        m_LeftHand_SecondaryTouch = m_LeftHand.FindAction("SecondaryTouch", throwIfNotFound: true);
        m_LeftHand_TriggerTouch = m_LeftHand.FindAction("TriggerTouch", throwIfNotFound: true);
        m_LeftHand_ControllerPosition = m_LeftHand.FindAction("ControllerPosition", throwIfNotFound: true);
        m_LeftHand_ControllerRotation = m_LeftHand.FindAction("ControllerRotation", throwIfNotFound: true);
        m_LeftHand_Haptics = m_LeftHand.FindAction("Haptics", throwIfNotFound: true);
        // RightHand
        m_RightHand = asset.FindActionMap("RightHand", throwIfNotFound: true);
        m_RightHand_TriggerPress = m_RightHand.FindAction("TriggerPress", throwIfNotFound: true);
        m_RightHand_Trigger = m_RightHand.FindAction("Trigger", throwIfNotFound: true);
        m_RightHand_PrimaryButton = m_RightHand.FindAction("PrimaryButton", throwIfNotFound: true);
        m_RightHand_PrimaryTouch = m_RightHand.FindAction("PrimaryTouch", throwIfNotFound: true);
        m_RightHand_Menu = m_RightHand.FindAction("Menu", throwIfNotFound: true);
        m_RightHand_Primary2DAxis = m_RightHand.FindAction("Primary2DAxis", throwIfNotFound: true);
        m_RightHand_Primary2DAxisClick = m_RightHand.FindAction("Primary2DAxisClick", throwIfNotFound: true);
        m_RightHand_Primary2DAxisTouch = m_RightHand.FindAction("Primary2DAxisTouch", throwIfNotFound: true);
        m_RightHand_Secondary2DAxis = m_RightHand.FindAction("Secondary2DAxis", throwIfNotFound: true);
        m_RightHand_Secondary2DAxisClick = m_RightHand.FindAction("Secondary2DAxisClick", throwIfNotFound: true);
        m_RightHand_Secondary2DAxisTouch = m_RightHand.FindAction("Secondary2DAxisTouch", throwIfNotFound: true);
        m_RightHand_Grip = m_RightHand.FindAction("Grip", throwIfNotFound: true);
        m_RightHand_GripPress = m_RightHand.FindAction("GripPress", throwIfNotFound: true);
        m_RightHand_GripForce = m_RightHand.FindAction("GripForce", throwIfNotFound: true);
        m_RightHand_SecondaryButton = m_RightHand.FindAction("SecondaryButton", throwIfNotFound: true);
        m_RightHand_SecondaryTouch = m_RightHand.FindAction("SecondaryTouch", throwIfNotFound: true);
        m_RightHand_TriggerTouch = m_RightHand.FindAction("TriggerTouch", throwIfNotFound: true);
        m_RightHand_ControllerPosition = m_RightHand.FindAction("ControllerPosition", throwIfNotFound: true);
        m_RightHand_ControllerRotation = m_RightHand.FindAction("ControllerRotation", throwIfNotFound: true);
        m_RightHand_Haptics = m_RightHand.FindAction("Haptics", throwIfNotFound: true);
        // HMD
        m_HMD = asset.FindActionMap("HMD", throwIfNotFound: true);
        m_HMD_hmdPosition = m_HMD.FindAction("hmdPosition", throwIfNotFound: true);
        m_HMD_hmdRotation = m_HMD.FindAction("hmdRotation", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Click = m_UI.FindAction("Click", throwIfNotFound: true);
        m_UI_pointerPosition = m_UI.FindAction("pointerPosition", throwIfNotFound: true);
        m_UI_pointerRotation = m_UI.FindAction("pointerRotation", throwIfNotFound: true);
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

    // LeftHand
    private readonly InputActionMap m_LeftHand;
    private ILeftHandActions m_LeftHandActionsCallbackInterface;
    private readonly InputAction m_LeftHand_TriggerPress;
    private readonly InputAction m_LeftHand_Trigger;
    private readonly InputAction m_LeftHand_PrimaryButton;
    private readonly InputAction m_LeftHand_PrimaryTouch;
    private readonly InputAction m_LeftHand_Menu;
    private readonly InputAction m_LeftHand_Primary2DAxis;
    private readonly InputAction m_LeftHand_Primary2DAxisClick;
    private readonly InputAction m_LeftHand_Primary2DAxisTouch;
    private readonly InputAction m_LeftHand_Secondary2DAxis;
    private readonly InputAction m_LeftHand_Secondary2DAxisClick;
    private readonly InputAction m_LeftHand_Secondary2DAxisTouch;
    private readonly InputAction m_LeftHand_Grip;
    private readonly InputAction m_LeftHand_GripPress;
    private readonly InputAction m_LeftHand_GripForce;
    private readonly InputAction m_LeftHand_SecondaryButton;
    private readonly InputAction m_LeftHand_SecondaryTouch;
    private readonly InputAction m_LeftHand_TriggerTouch;
    private readonly InputAction m_LeftHand_ControllerPosition;
    private readonly InputAction m_LeftHand_ControllerRotation;
    private readonly InputAction m_LeftHand_Haptics;
    public struct LeftHandActions
    {
        private @HVRInputActions m_Wrapper;
        public LeftHandActions(@HVRInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @TriggerPress => m_Wrapper.m_LeftHand_TriggerPress;
        public InputAction @Trigger => m_Wrapper.m_LeftHand_Trigger;
        public InputAction @PrimaryButton => m_Wrapper.m_LeftHand_PrimaryButton;
        public InputAction @PrimaryTouch => m_Wrapper.m_LeftHand_PrimaryTouch;
        public InputAction @Menu => m_Wrapper.m_LeftHand_Menu;
        public InputAction @Primary2DAxis => m_Wrapper.m_LeftHand_Primary2DAxis;
        public InputAction @Primary2DAxisClick => m_Wrapper.m_LeftHand_Primary2DAxisClick;
        public InputAction @Primary2DAxisTouch => m_Wrapper.m_LeftHand_Primary2DAxisTouch;
        public InputAction @Secondary2DAxis => m_Wrapper.m_LeftHand_Secondary2DAxis;
        public InputAction @Secondary2DAxisClick => m_Wrapper.m_LeftHand_Secondary2DAxisClick;
        public InputAction @Secondary2DAxisTouch => m_Wrapper.m_LeftHand_Secondary2DAxisTouch;
        public InputAction @Grip => m_Wrapper.m_LeftHand_Grip;
        public InputAction @GripPress => m_Wrapper.m_LeftHand_GripPress;
        public InputAction @GripForce => m_Wrapper.m_LeftHand_GripForce;
        public InputAction @SecondaryButton => m_Wrapper.m_LeftHand_SecondaryButton;
        public InputAction @SecondaryTouch => m_Wrapper.m_LeftHand_SecondaryTouch;
        public InputAction @TriggerTouch => m_Wrapper.m_LeftHand_TriggerTouch;
        public InputAction @ControllerPosition => m_Wrapper.m_LeftHand_ControllerPosition;
        public InputAction @ControllerRotation => m_Wrapper.m_LeftHand_ControllerRotation;
        public InputAction @Haptics => m_Wrapper.m_LeftHand_Haptics;
        public InputActionMap Get() { return m_Wrapper.m_LeftHand; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LeftHandActions set) { return set.Get(); }
        public void SetCallbacks(ILeftHandActions instance)
        {
            if (m_Wrapper.m_LeftHandActionsCallbackInterface != null)
            {
                @TriggerPress.started -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnTriggerPress;
                @TriggerPress.performed -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnTriggerPress;
                @TriggerPress.canceled -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnTriggerPress;
                @Trigger.started -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnTrigger;
                @Trigger.performed -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnTrigger;
                @Trigger.canceled -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnTrigger;
                @PrimaryButton.started -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnPrimaryButton;
                @PrimaryButton.performed -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnPrimaryButton;
                @PrimaryButton.canceled -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnPrimaryButton;
                @PrimaryTouch.started -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnPrimaryTouch;
                @PrimaryTouch.performed -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnPrimaryTouch;
                @PrimaryTouch.canceled -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnPrimaryTouch;
                @Menu.started -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnMenu;
                @Primary2DAxis.started -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnPrimary2DAxis;
                @Primary2DAxis.performed -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnPrimary2DAxis;
                @Primary2DAxis.canceled -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnPrimary2DAxis;
                @Primary2DAxisClick.started -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnPrimary2DAxisClick;
                @Primary2DAxisClick.performed -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnPrimary2DAxisClick;
                @Primary2DAxisClick.canceled -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnPrimary2DAxisClick;
                @Primary2DAxisTouch.started -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnPrimary2DAxisTouch;
                @Primary2DAxisTouch.performed -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnPrimary2DAxisTouch;
                @Primary2DAxisTouch.canceled -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnPrimary2DAxisTouch;
                @Secondary2DAxis.started -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnSecondary2DAxis;
                @Secondary2DAxis.performed -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnSecondary2DAxis;
                @Secondary2DAxis.canceled -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnSecondary2DAxis;
                @Secondary2DAxisClick.started -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnSecondary2DAxisClick;
                @Secondary2DAxisClick.performed -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnSecondary2DAxisClick;
                @Secondary2DAxisClick.canceled -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnSecondary2DAxisClick;
                @Secondary2DAxisTouch.started -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnSecondary2DAxisTouch;
                @Secondary2DAxisTouch.performed -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnSecondary2DAxisTouch;
                @Secondary2DAxisTouch.canceled -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnSecondary2DAxisTouch;
                @Grip.started -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnGrip;
                @Grip.performed -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnGrip;
                @Grip.canceled -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnGrip;
                @GripPress.started -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnGripPress;
                @GripPress.performed -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnGripPress;
                @GripPress.canceled -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnGripPress;
                @GripForce.started -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnGripForce;
                @GripForce.performed -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnGripForce;
                @GripForce.canceled -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnGripForce;
                @SecondaryButton.started -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnSecondaryButton;
                @SecondaryButton.performed -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnSecondaryButton;
                @SecondaryButton.canceled -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnSecondaryButton;
                @SecondaryTouch.started -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnSecondaryTouch;
                @SecondaryTouch.performed -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnSecondaryTouch;
                @SecondaryTouch.canceled -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnSecondaryTouch;
                @TriggerTouch.started -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnTriggerTouch;
                @TriggerTouch.performed -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnTriggerTouch;
                @TriggerTouch.canceled -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnTriggerTouch;
                @ControllerPosition.started -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnControllerPosition;
                @ControllerPosition.performed -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnControllerPosition;
                @ControllerPosition.canceled -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnControllerPosition;
                @ControllerRotation.started -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnControllerRotation;
                @ControllerRotation.performed -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnControllerRotation;
                @ControllerRotation.canceled -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnControllerRotation;
                @Haptics.started -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnHaptics;
                @Haptics.performed -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnHaptics;
                @Haptics.canceled -= m_Wrapper.m_LeftHandActionsCallbackInterface.OnHaptics;
            }
            m_Wrapper.m_LeftHandActionsCallbackInterface = instance;
            if (instance != null)
            {
                @TriggerPress.started += instance.OnTriggerPress;
                @TriggerPress.performed += instance.OnTriggerPress;
                @TriggerPress.canceled += instance.OnTriggerPress;
                @Trigger.started += instance.OnTrigger;
                @Trigger.performed += instance.OnTrigger;
                @Trigger.canceled += instance.OnTrigger;
                @PrimaryButton.started += instance.OnPrimaryButton;
                @PrimaryButton.performed += instance.OnPrimaryButton;
                @PrimaryButton.canceled += instance.OnPrimaryButton;
                @PrimaryTouch.started += instance.OnPrimaryTouch;
                @PrimaryTouch.performed += instance.OnPrimaryTouch;
                @PrimaryTouch.canceled += instance.OnPrimaryTouch;
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
                @Primary2DAxis.started += instance.OnPrimary2DAxis;
                @Primary2DAxis.performed += instance.OnPrimary2DAxis;
                @Primary2DAxis.canceled += instance.OnPrimary2DAxis;
                @Primary2DAxisClick.started += instance.OnPrimary2DAxisClick;
                @Primary2DAxisClick.performed += instance.OnPrimary2DAxisClick;
                @Primary2DAxisClick.canceled += instance.OnPrimary2DAxisClick;
                @Primary2DAxisTouch.started += instance.OnPrimary2DAxisTouch;
                @Primary2DAxisTouch.performed += instance.OnPrimary2DAxisTouch;
                @Primary2DAxisTouch.canceled += instance.OnPrimary2DAxisTouch;
                @Secondary2DAxis.started += instance.OnSecondary2DAxis;
                @Secondary2DAxis.performed += instance.OnSecondary2DAxis;
                @Secondary2DAxis.canceled += instance.OnSecondary2DAxis;
                @Secondary2DAxisClick.started += instance.OnSecondary2DAxisClick;
                @Secondary2DAxisClick.performed += instance.OnSecondary2DAxisClick;
                @Secondary2DAxisClick.canceled += instance.OnSecondary2DAxisClick;
                @Secondary2DAxisTouch.started += instance.OnSecondary2DAxisTouch;
                @Secondary2DAxisTouch.performed += instance.OnSecondary2DAxisTouch;
                @Secondary2DAxisTouch.canceled += instance.OnSecondary2DAxisTouch;
                @Grip.started += instance.OnGrip;
                @Grip.performed += instance.OnGrip;
                @Grip.canceled += instance.OnGrip;
                @GripPress.started += instance.OnGripPress;
                @GripPress.performed += instance.OnGripPress;
                @GripPress.canceled += instance.OnGripPress;
                @GripForce.started += instance.OnGripForce;
                @GripForce.performed += instance.OnGripForce;
                @GripForce.canceled += instance.OnGripForce;
                @SecondaryButton.started += instance.OnSecondaryButton;
                @SecondaryButton.performed += instance.OnSecondaryButton;
                @SecondaryButton.canceled += instance.OnSecondaryButton;
                @SecondaryTouch.started += instance.OnSecondaryTouch;
                @SecondaryTouch.performed += instance.OnSecondaryTouch;
                @SecondaryTouch.canceled += instance.OnSecondaryTouch;
                @TriggerTouch.started += instance.OnTriggerTouch;
                @TriggerTouch.performed += instance.OnTriggerTouch;
                @TriggerTouch.canceled += instance.OnTriggerTouch;
                @ControllerPosition.started += instance.OnControllerPosition;
                @ControllerPosition.performed += instance.OnControllerPosition;
                @ControllerPosition.canceled += instance.OnControllerPosition;
                @ControllerRotation.started += instance.OnControllerRotation;
                @ControllerRotation.performed += instance.OnControllerRotation;
                @ControllerRotation.canceled += instance.OnControllerRotation;
                @Haptics.started += instance.OnHaptics;
                @Haptics.performed += instance.OnHaptics;
                @Haptics.canceled += instance.OnHaptics;
            }
        }
    }
    public LeftHandActions @LeftHand => new LeftHandActions(this);

    // RightHand
    private readonly InputActionMap m_RightHand;
    private IRightHandActions m_RightHandActionsCallbackInterface;
    private readonly InputAction m_RightHand_TriggerPress;
    private readonly InputAction m_RightHand_Trigger;
    private readonly InputAction m_RightHand_PrimaryButton;
    private readonly InputAction m_RightHand_PrimaryTouch;
    private readonly InputAction m_RightHand_Menu;
    private readonly InputAction m_RightHand_Primary2DAxis;
    private readonly InputAction m_RightHand_Primary2DAxisClick;
    private readonly InputAction m_RightHand_Primary2DAxisTouch;
    private readonly InputAction m_RightHand_Secondary2DAxis;
    private readonly InputAction m_RightHand_Secondary2DAxisClick;
    private readonly InputAction m_RightHand_Secondary2DAxisTouch;
    private readonly InputAction m_RightHand_Grip;
    private readonly InputAction m_RightHand_GripPress;
    private readonly InputAction m_RightHand_GripForce;
    private readonly InputAction m_RightHand_SecondaryButton;
    private readonly InputAction m_RightHand_SecondaryTouch;
    private readonly InputAction m_RightHand_TriggerTouch;
    private readonly InputAction m_RightHand_ControllerPosition;
    private readonly InputAction m_RightHand_ControllerRotation;
    private readonly InputAction m_RightHand_Haptics;
    public struct RightHandActions
    {
        private @HVRInputActions m_Wrapper;
        public RightHandActions(@HVRInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @TriggerPress => m_Wrapper.m_RightHand_TriggerPress;
        public InputAction @Trigger => m_Wrapper.m_RightHand_Trigger;
        public InputAction @PrimaryButton => m_Wrapper.m_RightHand_PrimaryButton;
        public InputAction @PrimaryTouch => m_Wrapper.m_RightHand_PrimaryTouch;
        public InputAction @Menu => m_Wrapper.m_RightHand_Menu;
        public InputAction @Primary2DAxis => m_Wrapper.m_RightHand_Primary2DAxis;
        public InputAction @Primary2DAxisClick => m_Wrapper.m_RightHand_Primary2DAxisClick;
        public InputAction @Primary2DAxisTouch => m_Wrapper.m_RightHand_Primary2DAxisTouch;
        public InputAction @Secondary2DAxis => m_Wrapper.m_RightHand_Secondary2DAxis;
        public InputAction @Secondary2DAxisClick => m_Wrapper.m_RightHand_Secondary2DAxisClick;
        public InputAction @Secondary2DAxisTouch => m_Wrapper.m_RightHand_Secondary2DAxisTouch;
        public InputAction @Grip => m_Wrapper.m_RightHand_Grip;
        public InputAction @GripPress => m_Wrapper.m_RightHand_GripPress;
        public InputAction @GripForce => m_Wrapper.m_RightHand_GripForce;
        public InputAction @SecondaryButton => m_Wrapper.m_RightHand_SecondaryButton;
        public InputAction @SecondaryTouch => m_Wrapper.m_RightHand_SecondaryTouch;
        public InputAction @TriggerTouch => m_Wrapper.m_RightHand_TriggerTouch;
        public InputAction @ControllerPosition => m_Wrapper.m_RightHand_ControllerPosition;
        public InputAction @ControllerRotation => m_Wrapper.m_RightHand_ControllerRotation;
        public InputAction @Haptics => m_Wrapper.m_RightHand_Haptics;
        public InputActionMap Get() { return m_Wrapper.m_RightHand; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RightHandActions set) { return set.Get(); }
        public void SetCallbacks(IRightHandActions instance)
        {
            if (m_Wrapper.m_RightHandActionsCallbackInterface != null)
            {
                @TriggerPress.started -= m_Wrapper.m_RightHandActionsCallbackInterface.OnTriggerPress;
                @TriggerPress.performed -= m_Wrapper.m_RightHandActionsCallbackInterface.OnTriggerPress;
                @TriggerPress.canceled -= m_Wrapper.m_RightHandActionsCallbackInterface.OnTriggerPress;
                @Trigger.started -= m_Wrapper.m_RightHandActionsCallbackInterface.OnTrigger;
                @Trigger.performed -= m_Wrapper.m_RightHandActionsCallbackInterface.OnTrigger;
                @Trigger.canceled -= m_Wrapper.m_RightHandActionsCallbackInterface.OnTrigger;
                @PrimaryButton.started -= m_Wrapper.m_RightHandActionsCallbackInterface.OnPrimaryButton;
                @PrimaryButton.performed -= m_Wrapper.m_RightHandActionsCallbackInterface.OnPrimaryButton;
                @PrimaryButton.canceled -= m_Wrapper.m_RightHandActionsCallbackInterface.OnPrimaryButton;
                @PrimaryTouch.started -= m_Wrapper.m_RightHandActionsCallbackInterface.OnPrimaryTouch;
                @PrimaryTouch.performed -= m_Wrapper.m_RightHandActionsCallbackInterface.OnPrimaryTouch;
                @PrimaryTouch.canceled -= m_Wrapper.m_RightHandActionsCallbackInterface.OnPrimaryTouch;
                @Menu.started -= m_Wrapper.m_RightHandActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_RightHandActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_RightHandActionsCallbackInterface.OnMenu;
                @Primary2DAxis.started -= m_Wrapper.m_RightHandActionsCallbackInterface.OnPrimary2DAxis;
                @Primary2DAxis.performed -= m_Wrapper.m_RightHandActionsCallbackInterface.OnPrimary2DAxis;
                @Primary2DAxis.canceled -= m_Wrapper.m_RightHandActionsCallbackInterface.OnPrimary2DAxis;
                @Primary2DAxisClick.started -= m_Wrapper.m_RightHandActionsCallbackInterface.OnPrimary2DAxisClick;
                @Primary2DAxisClick.performed -= m_Wrapper.m_RightHandActionsCallbackInterface.OnPrimary2DAxisClick;
                @Primary2DAxisClick.canceled -= m_Wrapper.m_RightHandActionsCallbackInterface.OnPrimary2DAxisClick;
                @Primary2DAxisTouch.started -= m_Wrapper.m_RightHandActionsCallbackInterface.OnPrimary2DAxisTouch;
                @Primary2DAxisTouch.performed -= m_Wrapper.m_RightHandActionsCallbackInterface.OnPrimary2DAxisTouch;
                @Primary2DAxisTouch.canceled -= m_Wrapper.m_RightHandActionsCallbackInterface.OnPrimary2DAxisTouch;
                @Secondary2DAxis.started -= m_Wrapper.m_RightHandActionsCallbackInterface.OnSecondary2DAxis;
                @Secondary2DAxis.performed -= m_Wrapper.m_RightHandActionsCallbackInterface.OnSecondary2DAxis;
                @Secondary2DAxis.canceled -= m_Wrapper.m_RightHandActionsCallbackInterface.OnSecondary2DAxis;
                @Secondary2DAxisClick.started -= m_Wrapper.m_RightHandActionsCallbackInterface.OnSecondary2DAxisClick;
                @Secondary2DAxisClick.performed -= m_Wrapper.m_RightHandActionsCallbackInterface.OnSecondary2DAxisClick;
                @Secondary2DAxisClick.canceled -= m_Wrapper.m_RightHandActionsCallbackInterface.OnSecondary2DAxisClick;
                @Secondary2DAxisTouch.started -= m_Wrapper.m_RightHandActionsCallbackInterface.OnSecondary2DAxisTouch;
                @Secondary2DAxisTouch.performed -= m_Wrapper.m_RightHandActionsCallbackInterface.OnSecondary2DAxisTouch;
                @Secondary2DAxisTouch.canceled -= m_Wrapper.m_RightHandActionsCallbackInterface.OnSecondary2DAxisTouch;
                @Grip.started -= m_Wrapper.m_RightHandActionsCallbackInterface.OnGrip;
                @Grip.performed -= m_Wrapper.m_RightHandActionsCallbackInterface.OnGrip;
                @Grip.canceled -= m_Wrapper.m_RightHandActionsCallbackInterface.OnGrip;
                @GripPress.started -= m_Wrapper.m_RightHandActionsCallbackInterface.OnGripPress;
                @GripPress.performed -= m_Wrapper.m_RightHandActionsCallbackInterface.OnGripPress;
                @GripPress.canceled -= m_Wrapper.m_RightHandActionsCallbackInterface.OnGripPress;
                @GripForce.started -= m_Wrapper.m_RightHandActionsCallbackInterface.OnGripForce;
                @GripForce.performed -= m_Wrapper.m_RightHandActionsCallbackInterface.OnGripForce;
                @GripForce.canceled -= m_Wrapper.m_RightHandActionsCallbackInterface.OnGripForce;
                @SecondaryButton.started -= m_Wrapper.m_RightHandActionsCallbackInterface.OnSecondaryButton;
                @SecondaryButton.performed -= m_Wrapper.m_RightHandActionsCallbackInterface.OnSecondaryButton;
                @SecondaryButton.canceled -= m_Wrapper.m_RightHandActionsCallbackInterface.OnSecondaryButton;
                @SecondaryTouch.started -= m_Wrapper.m_RightHandActionsCallbackInterface.OnSecondaryTouch;
                @SecondaryTouch.performed -= m_Wrapper.m_RightHandActionsCallbackInterface.OnSecondaryTouch;
                @SecondaryTouch.canceled -= m_Wrapper.m_RightHandActionsCallbackInterface.OnSecondaryTouch;
                @TriggerTouch.started -= m_Wrapper.m_RightHandActionsCallbackInterface.OnTriggerTouch;
                @TriggerTouch.performed -= m_Wrapper.m_RightHandActionsCallbackInterface.OnTriggerTouch;
                @TriggerTouch.canceled -= m_Wrapper.m_RightHandActionsCallbackInterface.OnTriggerTouch;
                @ControllerPosition.started -= m_Wrapper.m_RightHandActionsCallbackInterface.OnControllerPosition;
                @ControllerPosition.performed -= m_Wrapper.m_RightHandActionsCallbackInterface.OnControllerPosition;
                @ControllerPosition.canceled -= m_Wrapper.m_RightHandActionsCallbackInterface.OnControllerPosition;
                @ControllerRotation.started -= m_Wrapper.m_RightHandActionsCallbackInterface.OnControllerRotation;
                @ControllerRotation.performed -= m_Wrapper.m_RightHandActionsCallbackInterface.OnControllerRotation;
                @ControllerRotation.canceled -= m_Wrapper.m_RightHandActionsCallbackInterface.OnControllerRotation;
                @Haptics.started -= m_Wrapper.m_RightHandActionsCallbackInterface.OnHaptics;
                @Haptics.performed -= m_Wrapper.m_RightHandActionsCallbackInterface.OnHaptics;
                @Haptics.canceled -= m_Wrapper.m_RightHandActionsCallbackInterface.OnHaptics;
            }
            m_Wrapper.m_RightHandActionsCallbackInterface = instance;
            if (instance != null)
            {
                @TriggerPress.started += instance.OnTriggerPress;
                @TriggerPress.performed += instance.OnTriggerPress;
                @TriggerPress.canceled += instance.OnTriggerPress;
                @Trigger.started += instance.OnTrigger;
                @Trigger.performed += instance.OnTrigger;
                @Trigger.canceled += instance.OnTrigger;
                @PrimaryButton.started += instance.OnPrimaryButton;
                @PrimaryButton.performed += instance.OnPrimaryButton;
                @PrimaryButton.canceled += instance.OnPrimaryButton;
                @PrimaryTouch.started += instance.OnPrimaryTouch;
                @PrimaryTouch.performed += instance.OnPrimaryTouch;
                @PrimaryTouch.canceled += instance.OnPrimaryTouch;
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
                @Primary2DAxis.started += instance.OnPrimary2DAxis;
                @Primary2DAxis.performed += instance.OnPrimary2DAxis;
                @Primary2DAxis.canceled += instance.OnPrimary2DAxis;
                @Primary2DAxisClick.started += instance.OnPrimary2DAxisClick;
                @Primary2DAxisClick.performed += instance.OnPrimary2DAxisClick;
                @Primary2DAxisClick.canceled += instance.OnPrimary2DAxisClick;
                @Primary2DAxisTouch.started += instance.OnPrimary2DAxisTouch;
                @Primary2DAxisTouch.performed += instance.OnPrimary2DAxisTouch;
                @Primary2DAxisTouch.canceled += instance.OnPrimary2DAxisTouch;
                @Secondary2DAxis.started += instance.OnSecondary2DAxis;
                @Secondary2DAxis.performed += instance.OnSecondary2DAxis;
                @Secondary2DAxis.canceled += instance.OnSecondary2DAxis;
                @Secondary2DAxisClick.started += instance.OnSecondary2DAxisClick;
                @Secondary2DAxisClick.performed += instance.OnSecondary2DAxisClick;
                @Secondary2DAxisClick.canceled += instance.OnSecondary2DAxisClick;
                @Secondary2DAxisTouch.started += instance.OnSecondary2DAxisTouch;
                @Secondary2DAxisTouch.performed += instance.OnSecondary2DAxisTouch;
                @Secondary2DAxisTouch.canceled += instance.OnSecondary2DAxisTouch;
                @Grip.started += instance.OnGrip;
                @Grip.performed += instance.OnGrip;
                @Grip.canceled += instance.OnGrip;
                @GripPress.started += instance.OnGripPress;
                @GripPress.performed += instance.OnGripPress;
                @GripPress.canceled += instance.OnGripPress;
                @GripForce.started += instance.OnGripForce;
                @GripForce.performed += instance.OnGripForce;
                @GripForce.canceled += instance.OnGripForce;
                @SecondaryButton.started += instance.OnSecondaryButton;
                @SecondaryButton.performed += instance.OnSecondaryButton;
                @SecondaryButton.canceled += instance.OnSecondaryButton;
                @SecondaryTouch.started += instance.OnSecondaryTouch;
                @SecondaryTouch.performed += instance.OnSecondaryTouch;
                @SecondaryTouch.canceled += instance.OnSecondaryTouch;
                @TriggerTouch.started += instance.OnTriggerTouch;
                @TriggerTouch.performed += instance.OnTriggerTouch;
                @TriggerTouch.canceled += instance.OnTriggerTouch;
                @ControllerPosition.started += instance.OnControllerPosition;
                @ControllerPosition.performed += instance.OnControllerPosition;
                @ControllerPosition.canceled += instance.OnControllerPosition;
                @ControllerRotation.started += instance.OnControllerRotation;
                @ControllerRotation.performed += instance.OnControllerRotation;
                @ControllerRotation.canceled += instance.OnControllerRotation;
                @Haptics.started += instance.OnHaptics;
                @Haptics.performed += instance.OnHaptics;
                @Haptics.canceled += instance.OnHaptics;
            }
        }
    }
    public RightHandActions @RightHand => new RightHandActions(this);

    // HMD
    private readonly InputActionMap m_HMD;
    private IHMDActions m_HMDActionsCallbackInterface;
    private readonly InputAction m_HMD_hmdPosition;
    private readonly InputAction m_HMD_hmdRotation;
    public struct HMDActions
    {
        private @HVRInputActions m_Wrapper;
        public HMDActions(@HVRInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @hmdPosition => m_Wrapper.m_HMD_hmdPosition;
        public InputAction @hmdRotation => m_Wrapper.m_HMD_hmdRotation;
        public InputActionMap Get() { return m_Wrapper.m_HMD; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(HMDActions set) { return set.Get(); }
        public void SetCallbacks(IHMDActions instance)
        {
            if (m_Wrapper.m_HMDActionsCallbackInterface != null)
            {
                @hmdPosition.started -= m_Wrapper.m_HMDActionsCallbackInterface.OnHmdPosition;
                @hmdPosition.performed -= m_Wrapper.m_HMDActionsCallbackInterface.OnHmdPosition;
                @hmdPosition.canceled -= m_Wrapper.m_HMDActionsCallbackInterface.OnHmdPosition;
                @hmdRotation.started -= m_Wrapper.m_HMDActionsCallbackInterface.OnHmdRotation;
                @hmdRotation.performed -= m_Wrapper.m_HMDActionsCallbackInterface.OnHmdRotation;
                @hmdRotation.canceled -= m_Wrapper.m_HMDActionsCallbackInterface.OnHmdRotation;
            }
            m_Wrapper.m_HMDActionsCallbackInterface = instance;
            if (instance != null)
            {
                @hmdPosition.started += instance.OnHmdPosition;
                @hmdPosition.performed += instance.OnHmdPosition;
                @hmdPosition.canceled += instance.OnHmdPosition;
                @hmdRotation.started += instance.OnHmdRotation;
                @hmdRotation.performed += instance.OnHmdRotation;
                @hmdRotation.canceled += instance.OnHmdRotation;
            }
        }
    }
    public HMDActions @HMD => new HMDActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Click;
    private readonly InputAction m_UI_pointerPosition;
    private readonly InputAction m_UI_pointerRotation;
    public struct UIActions
    {
        private @HVRInputActions m_Wrapper;
        public UIActions(@HVRInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Click => m_Wrapper.m_UI_Click;
        public InputAction @pointerPosition => m_Wrapper.m_UI_pointerPosition;
        public InputAction @pointerRotation => m_Wrapper.m_UI_pointerRotation;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Click.started -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @pointerPosition.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPointerPosition;
                @pointerPosition.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPointerPosition;
                @pointerPosition.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPointerPosition;
                @pointerRotation.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPointerRotation;
                @pointerRotation.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPointerRotation;
                @pointerRotation.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPointerRotation;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @pointerPosition.started += instance.OnPointerPosition;
                @pointerPosition.performed += instance.OnPointerPosition;
                @pointerPosition.canceled += instance.OnPointerPosition;
                @pointerRotation.started += instance.OnPointerRotation;
                @pointerRotation.performed += instance.OnPointerRotation;
                @pointerRotation.canceled += instance.OnPointerRotation;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    private int m_XRUsageSchemeIndex = -1;
    public InputControlScheme XRUsageScheme
    {
        get
        {
            if (m_XRUsageSchemeIndex == -1) m_XRUsageSchemeIndex = asset.FindControlSchemeIndex("XR Usage");
            return asset.controlSchemes[m_XRUsageSchemeIndex];
        }
    }
    public interface ILeftHandActions
    {
        void OnTriggerPress(InputAction.CallbackContext context);
        void OnTrigger(InputAction.CallbackContext context);
        void OnPrimaryButton(InputAction.CallbackContext context);
        void OnPrimaryTouch(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
        void OnPrimary2DAxis(InputAction.CallbackContext context);
        void OnPrimary2DAxisClick(InputAction.CallbackContext context);
        void OnPrimary2DAxisTouch(InputAction.CallbackContext context);
        void OnSecondary2DAxis(InputAction.CallbackContext context);
        void OnSecondary2DAxisClick(InputAction.CallbackContext context);
        void OnSecondary2DAxisTouch(InputAction.CallbackContext context);
        void OnGrip(InputAction.CallbackContext context);
        void OnGripPress(InputAction.CallbackContext context);
        void OnGripForce(InputAction.CallbackContext context);
        void OnSecondaryButton(InputAction.CallbackContext context);
        void OnSecondaryTouch(InputAction.CallbackContext context);
        void OnTriggerTouch(InputAction.CallbackContext context);
        void OnControllerPosition(InputAction.CallbackContext context);
        void OnControllerRotation(InputAction.CallbackContext context);
        void OnHaptics(InputAction.CallbackContext context);
    }
    public interface IRightHandActions
    {
        void OnTriggerPress(InputAction.CallbackContext context);
        void OnTrigger(InputAction.CallbackContext context);
        void OnPrimaryButton(InputAction.CallbackContext context);
        void OnPrimaryTouch(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
        void OnPrimary2DAxis(InputAction.CallbackContext context);
        void OnPrimary2DAxisClick(InputAction.CallbackContext context);
        void OnPrimary2DAxisTouch(InputAction.CallbackContext context);
        void OnSecondary2DAxis(InputAction.CallbackContext context);
        void OnSecondary2DAxisClick(InputAction.CallbackContext context);
        void OnSecondary2DAxisTouch(InputAction.CallbackContext context);
        void OnGrip(InputAction.CallbackContext context);
        void OnGripPress(InputAction.CallbackContext context);
        void OnGripForce(InputAction.CallbackContext context);
        void OnSecondaryButton(InputAction.CallbackContext context);
        void OnSecondaryTouch(InputAction.CallbackContext context);
        void OnTriggerTouch(InputAction.CallbackContext context);
        void OnControllerPosition(InputAction.CallbackContext context);
        void OnControllerRotation(InputAction.CallbackContext context);
        void OnHaptics(InputAction.CallbackContext context);
    }
    public interface IHMDActions
    {
        void OnHmdPosition(InputAction.CallbackContext context);
        void OnHmdRotation(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnClick(InputAction.CallbackContext context);
        void OnPointerPosition(InputAction.CallbackContext context);
        void OnPointerRotation(InputAction.CallbackContext context);
    }
}
#endif