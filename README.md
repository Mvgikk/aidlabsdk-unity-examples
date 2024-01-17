# aidlabsdk-unity-examples -> example_panel

`example_panel` branch contains an example demonstrating the integration and usage of AidLabSDK in Unity applications.

It contains interactive [panel](ScreenShot2) on the screen with circle next to it that changes color based on detected wearstate from the Aidmed device.

Checking different toggles will show received data on the screen.


Panel is also capable of drawing ECG chart on the screen by checking `Plot ECG` toggle

Here we use ECG data from device and prepare it using Pan Tompkins algorithm.

## Installation

Follow the steps mentioned in the [Installation](#Installation) of main branch section to clone the repository and set up the Unity project.

## Usage

1. Open the Unity project containing the examples.

2. Navigate to the `Assets/Scenes` folder and open `SampleScene.unity`.

3. Objects on SampleScene should look like this [Objects on the scene](#ScreenShot1):

4. Run the scene in the Unity editor to see the example in action.

5. To open panel on the scene click on Circle while in play mode

--- 

## Worth paying attention
Panel
![ScreenShot2](https://i.gyazo.com/f4cf546e6f4478bedaae5b8c75145d90.png)

Objects on the scene
![ScreenShot1](https://i.gyazo.com/3cba9bc32e3716574fe21a43836bdd46.png)

Chart
![ScreenShot](https://i.gyazo.com/f5b1c792a3744c8b7eab87dbb6a8d111.png)







