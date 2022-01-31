using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(LoginManager))]

public class LoginManagerEditorScript : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        EditorGUILayout.HelpBox("This  script is responsible for connecting to Photn Servers.", MessageType.Info);


        LoginManager loginManager = (LoginManager)target;
        if(GUILayout.Button("Connect Anonymously"))
        {
            loginManager.ConnectAnonemously();
        }

    }
}