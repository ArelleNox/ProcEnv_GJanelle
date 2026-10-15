#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

// À placer dans un dossier nommé "Editor"
[CustomEditor(typeof(VegetationScatter))]
public class VegetationScatterEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        var g = (VegetationScatter)target;

        if (GUILayout.Button("Generate")) g.Generate();
        {
            g.Generate();
            EditorUtility.SetDirty(g);
        }
    }
}
#endif