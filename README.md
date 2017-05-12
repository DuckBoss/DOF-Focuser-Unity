# D.O.F.Focuser-Unity
A script to dynamically change D.O.F. focus in the new post-processing stack in Unity 5.
This script is a modified and upgraded version of Keijiro's FocusPuller script.

![](https://cloud.githubusercontent.com/assets/20238115/25970432/a1ec968c-3666-11e7-9f7d-0c01469ef3a6.gif)

## Requirements :
- Unity 5
- This project requires the Post Processing Stack from Unity-Technologies
  https://github.com/Unity-Technologies/PostProcessing
  
- This project also requires the Post Processing Controller Script from Keijiro
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


# License:
------------------------------
MIT License

Copyright (c) [2017] [Jason Jerome]

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.


Basically this license gives permissions for:
- Commercial Use
- Distribution
- Modification
- Private Use
