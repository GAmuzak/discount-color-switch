using UnityEngine;

public class Player : MonoBehaviour
{
    public float upSpod = 5.0f;
    public Rigidbody2D rb;
    void Update()
    {
        if (Input.GetButtonDown("Jump") || Input.GetMouseButton(0))
        {
            rb.velocity = Vector2.up * upSpod;
            //setting velocity instead of adding force, since the game wants an instant constant jump height
        }
    }
}
