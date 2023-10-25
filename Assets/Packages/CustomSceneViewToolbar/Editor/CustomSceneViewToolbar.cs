using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[InitializeOnLoad]
public static class CustomSceneViewToolbar
{
    public static List<Action> OnGUIActions { get; } = new();

    static CustomSceneViewToolbar()
    {
        SceneView.duringSceneGui += OnGUI;
    }

    private static void OnGUI(SceneView sceneView)
    {
        GUILayout.BeginArea(new Rect(0, 0, Screen.width / EditorGUIUtility.pixelsPerPoint, Screen.height / EditorGUIUtility.pixelsPerPoint));
        if (OnGUIActions.Count != 0)
        {
            GUILayout.BeginHorizontal("toolbar");
            foreach (var action in OnGUIActions)
            {
                action();
            }
            GUILayout.FlexibleSpace();
            GUILayout.EndHorizontal();
        }
        GUILayout.EndArea();
    }
}