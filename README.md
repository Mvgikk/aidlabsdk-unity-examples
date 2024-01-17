# aidlabsdk-unity-examples -> example_orientation

`example_orientation` branch contains an example demonstrating the integration and usage of AidLabSDK in Unity applications focused on orientation sample.
It contains simple square object moved on screen based on orientation sample followed by camera.

## Installation

Follow the steps mentioned in the [Installation](#Installation) of main branch section to clone the repository and set up the Unity project.

## Usage

1. Open the Unity project containing the examples.

2. Navigate to the `Assets/Scenes` folder and open `SampleScene.unity`.

3. Make sure there is `Example` object on the scene with `Example.cs` script attached to it.

4. Make sure `CameraFollow.cs` script is attachted to `MainCamera` 

5. Run the scene in the Unity editor to see the example in action.

6. Main functionality is in the `Assets/Scripts/Example.cs`

--- 

## Worth paying attention

Specify orientation signal in signals array\
`Assets/AidlabPlugin/AidlabPlugin/AidLabSDK.cs`

```c
        public byte[] GetCollectCommand(IntPtr aidlabAddress) 
        
            byte[] signals = {(byte)Signal.Orientation};
```





