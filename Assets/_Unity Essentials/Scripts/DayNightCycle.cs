using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    // Number of seconds for a full day to pass (editable in the Inspector)
    [Tooltip("The number of real seconds it takes for a full day to pass")]
    public float dayDurationInSeconds = 120f;  // Default 120 seconds for a day

    // Rotation speed based on day duration
    private float rotationSpeed;

    void Start()
    {
        // Calculate the rotation speed (360 degrees for a full day)
        rotationSpeed = 360f / dayDurationInSeconds;
    }

    void Update()
    {
        // Rotate the light around the X-axis (for a basic day/night cycle)
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
    }
}