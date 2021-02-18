using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class EditorSnap : MonoBehaviour
{
    [SerializeField][Range(1f, 20f)] float gridSize = 10f;

    void Update()
    {
        Vector3 snapPos;
        snapPos.x = Mathf.RoundToInt(transform.position.x / gridSize) * 10f;
        snapPos.z = Mathf.RoundToInt(transform.position.z / gridSize) * 10f;
        transform.position = new Vector3(snapPos.x, 0f, snapPos.z);
    }
}
