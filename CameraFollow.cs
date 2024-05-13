using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Reference to the sphere GameObject

    private Vector3 offset; // Offset between the camera and the sphere

    private void Start()
    {
        offset = transform.position - target.position; // Calculate the initial offset
    }

    private void LateUpdate()
    {
        transform.position = target.position + offset; // Update the camera's position based on the sphere's position
    }
}