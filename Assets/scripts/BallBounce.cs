using UnityEngine;

public class BallBounce : MonoBehaviour
{
    public float bounceForce = 10f; // Strength of the bounce
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Cache Rigidbody2D for efficiency
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ring"))
        {
            // Calculate bounce direction
            Vector2 bounceDirection = (transform.position - collision.transform.position).normalized;

            // Apply bounce force
            rb.linearVelocity = bounceDirection * bounceForce;

            Debug.Log("Ball bounced off the ring!");
        }
    }
}
