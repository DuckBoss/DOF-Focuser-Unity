# D.O.F.Focuser - Unity 2017+
A script to dynamically change D.O.F. (Depth of Field) focus in the new post-processing stack(v2) in Unity 2017+.

[![GitHub release](https://img.shields.io/badge/Build-2.0-brightgreen.svg)](https://github.com/DuckBoss/DOF-Focuser-Unity/releases/latest)
[![Packagist](https://img.shields.io/badge/License-MIT-blue.svg)](https://github.com/DuckBoss/DOF-Focuser-Unity/blob/master/LICENSE)

*This script is based on [Keijiro's](https://github.com/keijiro) post processing stack(v1). My updated version supports the newer post processing stack(v2).*

![](https://cloud.githubusercontent.com/assets/20238115/25970432/a1ec968c-3666-11e7-9f7d-0c01469ef3a6.gif)

## Requirements :
- Unity 2017+
- This project is NOT COMPATIBLE with Unity 5 which uses the Post Processing Stack (v1).
- This project requires the Post Processing Stack (v2) from Unity-Technologies.
  https://github.com/Unity-Technologies/PostProcessing

## Installation :
- Put the two scripts (DOF_Focuser_Editor.cs and DOF_Focuser.cs) into your project and you're set!
- Please make sure the Post Processing Stack(v2) is in your project, NOT (v1).

Side Note:
<i>In Unity 2018+, it is possible to download the new Post Processing Stack(v2) through the Package Manager.</i>

## Usage :
- Add the 'DOF_Focuser.cs' onto a gameobject (preferably the Camera, although not required).
- Transform Mode: actively sets the D.O.F. focus point to an object in the scene.
- View Mode: actively sets the D.O.F. focus point based on what your camera is looking at (adjusts focus distance).

## Extra Notes :
- The Transform Mode is most useful when tracking specific objects.
- The View Mode is most useful in first person games where you require refocusing the D.O.F. based on what your player/camera is looking at.

## Bugs, Issues, or Feature Requests?
Use the github issue/feature template provided in the repository.
