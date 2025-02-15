using UnityEngine;
using System.Collections;

public class RingCollision : MonoBehaviour
{
    public GameObject ball;  // Assign Ball in Inspector
    public float sizeIncrease = 0.2f; // Amount to increase ball size
    public float collapseSpeed = 0.05f; // Speed of ring collapse

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Ball")) // Check if ball exits
        {
            Debug.Log("Ball exited the ring! Increasing size and collapsing ring.");

            // Increase ball size
            ball.transform.localScale += new Vector3(sizeIncrease, sizeIncrease, 0);

            // Start collapse animation and destroy the ring
            StartCoroutine(CollapseRing());
        }
    }

    IEnumerator CollapseRing()
    {
        for (float scale = 1f; scale > 0; scale -= 0.1f)
        {
            transform.localScale = new Vector3(scale, scale, 1);
            yield return new WaitForSeconds(collapseSpeed);
        }
        Destroy(gameObject); // Destroy ring after shrinking
    }
}
