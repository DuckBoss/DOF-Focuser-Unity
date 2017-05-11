using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(JJ_DOF_Focuser))]
public class JJ_DOF_Editor : Editor {

	public override void OnInspectorGUI() {
		JJ_DOF_Focuser myTarget = (JJ_DOF_Focuser)target;

		myTarget.DebugMode = EditorGUILayout.Toggle("Debug Mode:", myTarget.DebugMode);
		myTarget.focusMode = (JJ_DOF_Focuser.FocusMode)EditorGUILayout.EnumPopup("Focuser Type", myTarget.focusMode);

		if(myTarget.focusMode == JJ_DOF_Focuser.FocusMode.Transform) {
			myTarget.Target = (Transform)EditorGUILayout.ObjectField("Target:", myTarget.Target, typeof(Transform), true);
			myTarget.Offset = EditorGUILayout.FloatField("Offset:", myTarget.Offset);
			myTarget.Speed = EditorGUILayout.FloatField("Speed:", myTarget.Speed);
		}
		else if(myTarget.focusMode == JJ_DOF_Focuser.FocusMode.View) {
			/* Best Settings - 
			myTarget._controller.depthOfField.useCameraFov = false;
			myTarget._controller.depthOfField.focusDistance = 5.1f;
			myTarget._controller.depthOfField.focalLength = 65f;
			*/

			myTarget.StandardFocusDistance = EditorGUILayout.FloatField("Default Distance:", myTarget.StandardFocusDistance);
			myTarget.Speed = EditorGUILayout.FloatField("Speed:", myTarget.Speed);
		}
	}

}
