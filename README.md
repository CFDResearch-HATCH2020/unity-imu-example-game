# Example sensor-driven Unity game

This project will get you started on a very simple game driven by a MetaWear IMU sensor. 

The key functionality provided in this project is in Assets/Plugins/Android/MetaWearPlugin.jar. This jar file enables Unity to communicate with the MetaWear IMU sensor. 

## Important notes

The provided MetaWearPlugin is hard-coded to communicate with a Unity asset named "BlueCharacter". If you want to change this, you'll have to re-build the plugin.

## Instructions

1. Install Unity (2019 recommended)

2. Open the Unity Hub app, and skip the install wizard to choose specific installation preferences. Alternatively, if you already have Unity installed, navigate to the Installs section of Unity Hub to modify your installation.

3. Select Android Build support  
	 3a. Make sure to add Android SDK and NDK, as well as OpenJDK  
	 3b. Alternatively, if you already have the Android SDK and NDK and a Java JDK, you can tell Unity to use those packages. Be careful with versioning.  
   
4. Download or clone the Unity IMU example game from CFDRC GitHub

5. Open Unity and add project, select downloaded files

6. Specify Android as target platform

7. Enable developer options and USB debugging on Android device (https://developer.android.com/studio/debug/dev-options)

8. If on Windows, make sure USB device driver installed

9. Set Android device to allow USB debugging

10. Make sure Bluetooth is turned on, and pair sensor with device

11. In Unity, select Build and Run
   11a. You will be prompted to specify a location to save the file. You can select any location on your computer - it won't matter for on-device debugging.

12. Control a game using a sensor!

## Helpful links

https://www.androidauthority.com/an-introduction-to-unity3d-666066/

https://docs.unity3d.com/Manual/android-sdksetup.html

https://www.androidauthority.com/can-build-basic-android-game-just-7-minutes-unity-813947/
