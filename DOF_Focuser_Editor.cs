using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(DOF_Focuser))]
public class DOF_Focuser_Editor : Editor
{

    public override void OnInspectorGUI()
    {
        DOF_Focuser myTarget = (DOF_Focuser)target;

        myTarget.FocusMode = (DOF_Focuser.FocusType)EditorGUILayout.EnumPopup("Focuser Type", myTarget.FocusMode);

        if (myTarget.FocusMode == DOF_Focuser.FocusType.Transform)
        {
            myTarget.Target = (Transform)EditorGUILayout.ObjectField("Target:", myTarget.Target, typeof(Transform), true);
            myTarget.Speed = EditorGUILayout.FloatField("Speed:", myTarget.Speed);
        }
        else if (myTarget.FocusMode == DOF_Focuser.FocusType.View)
        {
            myTarget._defaultFocusDistance = EditorGUILayout.FloatField("Default Distance:", myTarget._defaultFocusDistance);
            myTarget.Speed = EditorGUILayout.FloatField("Speed:", myTarget.Speed);
        }

		myTarget.Debugging = EditorGUILayout.Toggle("Debug Mode:", myTarget.Debugging);

    }
}
