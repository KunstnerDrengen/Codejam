using UnityEngine;

public class Zoom : MonoBehaviour
{
    public float zoomSpeed = 0.1f;
    public Camera cam;

    private float initialSize;
    private float minSize;
    private float maxSize;

    void Start()
    {        
        // Store the initial size of the camera
        initialSize = cam.orthographicSize;

        // Set the minimum size (zoom in limit) to one third of the initial size
        minSize = initialSize / 3f;

        // Set the maximum size (zoom out limit) to the initial size
        maxSize = initialSize;
    }

    void Update()
    {
        if (Input.touchCount == 2)
        {
            // Store both touches.
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            // Find the position in the previous frame of each touch.
            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            // Find the magnitude of the vector (the distance) between the touches in each frame.
            float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

            // Find the difference in the distances between each frame.
            float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

            // ... change the orthographic size based on the change in distance between the touches.
            cam.orthographicSize += deltaMagnitudeDiff * zoomSpeed;

            // Clamp the orthographic size to be between the minimum and maximum size.
            cam.orthographicSize = Mathf.Clamp(cam.orthographicSize, minSize, maxSize);
        }
    }
}