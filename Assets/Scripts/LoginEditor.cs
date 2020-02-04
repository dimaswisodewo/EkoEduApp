using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;

[CustomEditor(typeof(LoginController))]
public class LoginEditor : Editor
{

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        LoginController myScript = (LoginController)target;

        if (GUILayout.Button("Delete PlayerPref"))
        {
            myScript.DeleteKeyPlayerPref("Profile");
        }
    }
}

#endif
