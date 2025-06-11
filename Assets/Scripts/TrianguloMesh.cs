using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class TrianguloMesh : MonoBehaviour
{
    void Start()
    {
        Mesh mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;

        // Vértices de una pirámide (base triangular)
        Vector3[] vertices = new Vector3[]
        {
            new Vector3(0, 0, 0),  // v0
            new Vector3(1, 0, 0),  // v1
            new Vector3(0.5f, 0, Mathf.Sqrt(0.75f)),  // v2
            new Vector3(0.5f, 1, Mathf.Sqrt(0.75f)/3) // v3 (punta)
        };

        // Caras (triángulos)
        int[] triangles = new int[]
        {
            0, 1, 2, // base
            0, 1, 3,
            1, 2, 3,
            2, 0, 3
        };

        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();
    }
}
