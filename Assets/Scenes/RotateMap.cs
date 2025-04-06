using UnityEngine;

public class RotateMap: MonoBehaviour
{
    public float moveSpeed = 5f; // Speed at which the model moves
    public float rotationSpeed = 100f; // Speed at which the model rotates
    public float zoomSpeed = 10f; // Speed at which zoom in and out occurs
    public Camera camera; // Reference to the camera

    void Start()
    {
        if (camera == null)
        {
            Debug.LogError("Camera is not assigned!");
        }
    }

    void Update()
    {
        // Get input for movement
        float horizontal = Input.GetAxis("Horizontal"); // A/D keys or Left/Right arrow keys
        float vertical = Input.GetAxis("Vertical"); // W/S keys or Up/Down arrow keys

        // Calculate movement direction
        Vector3 moveDirection = new Vector3(horizontal, 0, vertical).normalized;

        // Move the model
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime, Space.World);

        // Rotate the model with mouse input
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        transform.Rotate(Vector3.up * mouseX * rotationSpeed * Time.deltaTime);
        transform.Rotate(Vector3.left * mouseY * rotationSpeed * Time.deltaTime);

        // Zoom in and out with the mouse scroll wheel
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (camera != null && camera.orthographic)
        {
            camera.orthographicSize -= scroll * zoomSpeed;
            // Clamp the orthographic size to prevent zooming too far in or out
            camera.orthographicSize = Mathf.Clamp(camera.orthographicSize, 1f, 100f);
        }
    }
}
