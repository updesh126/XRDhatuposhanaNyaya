using UnityEngine;

public class SphereGenerator : MonoBehaviour
{
    public GameObject largeSpherePrefab;
    public GameObject smallSpherePrefab;
    public int subdivisionLevel = 10; // Adjust subdivision level as needed

    void Start()
    {
        // Instantiate the large sphere
        GameObject largeSphere = Instantiate(largeSpherePrefab, Vector3.zero, Quaternion.identity);

        // Get the large sphere's mesh
        Mesh largeSphereMesh = largeSphere.GetComponent<MeshFilter>().mesh;

        // Subdivide the large sphere mesh
        largeSphereMesh = SubdivideMesh(largeSphereMesh, subdivisionLevel);

        // Iterate through vertices and instantiate small spheres
        for (int i = 0; i < largeSphereMesh.vertices.Length; i++)
        {
            Vector3 vertexPosition = largeSphereMesh.vertices[i];
            GameObject smallSphere = Instantiate(smallSpherePrefab, largeSphere.transform.TransformPoint(vertexPosition), Quaternion.identity);
            smallSphere.transform.parent = largeSphere.transform; // Set the large sphere as the parent
        }
    }

    Mesh SubdivideMesh(Mesh mesh, int levels)
    {
        for (int i = 0; i < levels; i++)
        {
            mesh = Subdivide(mesh);
        }
        return mesh;
    }

    Mesh Subdivide(Mesh mesh)
    {
        Vector3[] oldVertices = mesh.vertices;
        int[] triangles = mesh.triangles;

        Vector3[] newVertices = new Vector3[triangles.Length];
        Vector2[] newUVs = new Vector2[triangles.Length];

        for (int i = 0; i < triangles.Length; i += 3)
        {
            Vector3 v1 = oldVertices[triangles[i]];
            Vector3 v2 = oldVertices[triangles[i + 1]];
            Vector3 v3 = oldVertices[triangles[i + 2]];

            Vector3 newVertex = (v1 + v2 + v3) / 3f;

            int newIndex = i / 3 * 3;

            newVertices[newIndex] = v1;
            newVertices[newIndex + 1] = v2;
            newVertices[newIndex + 2] = v3;

            triangles[i] = newIndex;
            triangles[i + 1] = newIndex + 1;
            triangles[i + 2] = newIndex + 2;
        }

        mesh.vertices = newVertices;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();

        return mesh;
    }
}