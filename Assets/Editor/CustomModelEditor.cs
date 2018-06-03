using UnityEngine;
using System.Collections;
using UnityEditor;

[CustomEditor(typeof(CustomModel))]
public class CustomModelEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        CustomModel myScript = (CustomModel)target;
        if (GUILayout.Button("Build Object"))
        {
            myScript.InitModel();
        }
    }
}