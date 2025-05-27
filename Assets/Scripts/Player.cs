using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    float movement = 0f;
    public float movementSpeed = 10f;

    void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;
    }

    void FixedUpdate()
    {
        Vector2 velocity = rb.linearVelocity; 
        velocity.x = movement;
        rb.linearVelocity = velocity;
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("endGame"))
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
