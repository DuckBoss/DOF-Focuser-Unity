# D.O.F.Focuser-Unity
A script to dynamically change D.O.F. (Depth of Field) focus in the new post-processing stack in Unity 5.

[![GitHub release](https://img.shields.io/badge/Build-1.0-brightgreen.svg)](https://github.com/DuckBoss/DOF-Focuser-Unity/releases/latest)
[![Packagist](https://img.shields.io/badge/License-MIT-blue.svg)](https://github.com/DuckBoss/DOF-Focuser-Unity/blob/master/LICENSE)


*This script is a modified and upgraded version of [Keijiro's](https://github.com/keijiro) FocusPuller script.*

![](https://cloud.githubusercontent.com/assets/20238115/25970432/a1ec968c-3666-11e7-9f7d-0c01469ef3a6.gif)

## Requirements :
- Unity 5
- This project requires the Post Processing Stack (v1) from Unity-Technologies.
  https://github.com/Unity-Technologies/PostProcessing
  
- This project also requires the Post Processing Controller Script from [Keijiro](https://github.com/keijiro).
  https://github.com/keijiro/PostProcessingUtilities

## Installation :
- Put the two scripts (JJ_DOF_Editor.cs and JJ_DOF_Focuser.cs) into your project and you're set!


## Usage :
- Add the 'JJ_DOF_Focuser.cs' onto your main camera (the camera that has the post processing controller).
- Transform Mode: actively sets the D.O.F. focus point to an object in the scene.
- View Mode: actively sets the D.O.F. focus point based on what your camera is looking at (adjusts focus distance).

## Extra Notes :
- The Transform Mode is more useful when tracking specific objects.
- The View Mode is more useful in first person games where you require refocusing the D.O.F. based on what your player is looking at.
