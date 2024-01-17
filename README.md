# aidlabsdk-unity-examples -> example_respiration

`example_respiration` branch contains an example demonstrating the integration and usage of AidLabSDK in Unity applications specifically focused on respiration functionality.
It contains simple square object moved along Y-axis on screen based on respiration data.

## Installation

Follow the steps mentioned in the [Installation](#Installation) of main branch section to clone the repository and set up the Unity project.

## Usage

1. Open the Unity project containing the examples.

2. Navigate to the `Assets/Scenes` folder and open `SampleScene.unity`.

3. Make sure there is `Example` object on the scene with `Example.cs` script attached to it.

4. Run the scene in the Unity editor to see the example in action.

5. Observe how the square object moves along the Y-axis in response to the respiration data received from the AidLab device.

6. Main functionality is in the `Assets/Scripts/Example.cs`

---
## Worth paying attention

Specify respiration signal in signals array\
`Assets/AidlabPlugin/AidlabPlugin/AidLabSDK.cs`

```c
        public byte[] GetCollectCommand(IntPtr aidlabAddress) 
        
            byte[] signals = {(byte)Signal.Respiration};
```

