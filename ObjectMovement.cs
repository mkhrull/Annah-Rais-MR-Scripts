using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public Transform target;
    public float speed = 5f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 targetPosition = target.position;
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }
    }
}