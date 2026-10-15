#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

// À placer dans un dossier nommé "Editor"
[CustomEditor(typeof(TerrainPainter))]
public class TerrainPainterEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        var g = (TerrainPainter)target;

        if (GUILayout.Button("Paint")) g.Paint();
        {
           g.Paint();
            EditorUtility.SetDirty(g);
        }
    }
}
#endif