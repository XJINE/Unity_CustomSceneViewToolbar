using UnityEngine;
using UnityEditor;

[InitializeOnLoad]
public static class Sample
{
    static Sample()
    {
        CustomSceneViewToolbar.OnGUIActions.Add(() =>
        {
            GUILayout.Label("Custom");

            if (GUILayout.Button("SAMPLE_BUTTON"))
            {
                Camera.main.transform.position += Vector3.left;
            }
        });
    }
}
