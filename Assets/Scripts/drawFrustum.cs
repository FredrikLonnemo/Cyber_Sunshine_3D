using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawFrustum : MonoBehaviour
{
    void OnDrawGizmos()
    {
        // Gizmo Frustum
        Gizmos.matrix = transform.localToWorldMatrix;           // For the rotation bug
        Gizmos.color = Color.red;
        Gizmos.DrawFrustum(transform.position, Camera.main.fieldOfView, Camera.main.nearClipPlane, Camera.main.farClipPlane, Camera.main.aspect);
    }
}
