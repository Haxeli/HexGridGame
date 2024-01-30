using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(MeshGenerator))]
public class MeshGeneratorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        MeshGenerator meshGenerator = (MeshGenerator)target;

        if (GUILayout.Button("Generate Hex Mesh"))
        {
            meshGenerator.CreateHexMesh();
        }

        if (GUILayout.Button("Clear Hex Mesh"))
        {
            meshGenerator.ClearHexGridMesh();
        }
    }
}
