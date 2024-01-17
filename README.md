
# aidlabsdk-unity-examples

This repository contains a set of examples demonstrating the integration and usage of [Aidlab SDK](https://github.com/Aidlab/Aidlab-SDK) in Unity applications. AidLabSDK allows you to interact with [Aidmed](https://www.aidmed.ai/pl/) devices, allowing you to collect and analyze various data like Skin Temperature, Hearth Rate, etc.

## Table of Contents

- [Requirements](#requirements)
- [Installation](#installation)
- [Usage](#usage)
- [Branches](#branches)
- [Documentation](#documentation)


## Requirements

Before using the examples, make sure you have the following:

- Unity 2022.3.16f1
- Aidmed One device

## Installation

1. Clone this repository to your local machine:

    ```bash
    git clone https://github.com/Mvgikk/aidlabsdk-unity-examples.git
    ```

2. Open the Unity project using Unity Hub.

3. Make sure AidlabPlugin folder is available.


## Usage

1. Open the Unity project containing the examples.

2. Navigate to the `Assets/Scenes` folder and open `SampleScene.unity`.

3. Make sure there is `Example` object on the scene with `Example.cs` script attached to it.

4. Run the scene in the Unity editor to see the example in action.

## Branches

This repository has specific branches for different examples:

- **example_respiration** Example demonstrating respiration functionality.
  
- **example_orientation** Example showcasing orientation signal values.

- **example_respiration_throttle** Example respiration with throttling

- **example_panel** Example incorporating a interactive panel on the screen with wearstate,heartrate and chart visualization.

Feel free to explore and switch to the branch that corresponds to the functionality you're interested in.

## Documentation

Refer to the [AidLabSDK Documentation](https://www.aidlab.com/developer/docs) for detailed information on using the AidLabSDK.
