using UnityEngine;

public class RingRotation : MonoBehaviour
{
    public float rotationSpeed = 50f; // Speed of rotation
    public bool rotateClockwise = true; // Set this in Inspector

    void Update()
    {
        float direction = rotateClockwise ? -1f : 1f; // -1 for CW, 1 for ACW
        transform.Rotate(0, 0, direction * rotationSpeed * Time.deltaTime);
    }
}
