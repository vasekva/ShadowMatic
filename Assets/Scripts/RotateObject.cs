using UnityEngine;

public class RotateObject : MonoBehaviour
{
    private float rotationSpeed = 2.0f;
    private bool isXPressed = false;
    void OnMouseDrag()
    {
        Debug.Log("Mouse is pressed!");
        float zAxisRotation = Input.GetAxis("Mouse X") * rotationSpeed;
        float yAxisRotation = Input.GetAxis("Mouse Y") * rotationSpeed;
        
        if (!isXPressed)
            transform.Rotate(Vector3.back, zAxisRotation);
        else
            transform.Rotate(Vector3.up, zAxisRotation);
        transform.Rotate(Vector3.right, yAxisRotation);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.X))
            isXPressed = !isXPressed;
    }
}