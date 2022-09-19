using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private Mesh mesh;
    public int xSize;
    public int zSize;
    Vector3[] vertices;
    int[] triangles;
    public SpawnObject spawnObject;

    private void Start()
    {
        GetComponent<MeshFilter>().mesh = mesh = new Mesh();
        CreateTerrain();

        Vector2[] uvs = new Vector2[vertices.Length];
        for (int i = 0; i < uvs.Length; i++)
        {
            uvs[i] = new Vector2(vertices[i].x, vertices[i].z);
        }
        mesh.uv = uvs;
    }

    private void CreateTerrain()
    {
        vertices = new Vector3[(xSize + 1) * (zSize + 1)];
 

        for (int i = 0, z = 0; z <= zSize; z++)
        {
            for (int x = 0; x <= xSize; x++)
            {
                float y = 1;
                vertices[i] = new Vector3(x, y, z);
                spawnObject.CreateObject(x, y, z);
                i++;
            }
        }

        mesh.vertices = vertices;
        //mesh.uv = uv;
        triangles = new int[xSize * zSize * 6];

        int tris = 0;
        int vert = 0;
        for (int z = 0; z < zSize; z++)
        {
            for (int x = 0; x < xSize; x++)
            {
                triangles[tris + 0] = vert + 0;
                triangles[tris + 1] = vert + xSize + 1;
                triangles[tris + 2] = vert + 1;
                triangles[tris + 3] = vert + 1;
                triangles[tris + 4] = vert + xSize + 1;
                triangles[tris + 5] = vert + xSize + 2;

                vert++;
                tris += 6;
                mesh.triangles = triangles;
                mesh.RecalculateNormals();
            }
            vert++;
        }

    }

    private void OnDrawGizmos()
    {
        if (vertices != null)
        {
            for (int i = 0; i < vertices.Length; i++)
            {
                Gizmos.DrawSphere(vertices[i], .1f);
            }
        }
    }
}