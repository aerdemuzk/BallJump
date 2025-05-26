using UnityEngine;

public class Platform : MonoBehaviour
{
    float jumpForce = 8.6f;
    private Transform cam;

    private void Start()
    {
        cam = Camera.main.transform;
    }

    private void Update()
    {
        // Kamera 10 birim yukar� ��km��sa bu platformu sil
        if (transform.position.y < cam.position.y - 10f)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D player)
    {
        Rigidbody2D rb = player.collider.GetComponent<Rigidbody2D>();
        if (player.relativeVelocity.y <= 0f && rb != null)
        {
            Vector2 velocity = rb.linearVelocity;
            velocity.y = jumpForce;
            rb.linearVelocity = velocity;
        }
    }
}
