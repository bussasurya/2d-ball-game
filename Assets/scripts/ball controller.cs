using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed = 5f;  // Speed of movement
    public float jumpForce = 10f; // Force applied when jumping

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Move left and right using arrow keys or A/D keys
        float move = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(move * moveSpeed, rb.linearVelocity.y);

        // Jump when spacebar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ring"))
        {
            Debug.Log("Ball hit the ring!");

            // Bounce back effect
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, Mathf.Abs(rb.linearVelocity.y) * 1.2f);
        }
    }
}
