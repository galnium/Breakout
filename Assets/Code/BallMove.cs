using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    // Modifiable in inspector in Unity
    public float speed = 10;

    private Rigidbody2D rb2d;

    void Start()
    {
        // Automatically sets the Rigidbody2D variable without needing to do so in Unity.
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = transform.up * speed;
    }

    void Update()
    {
        // Respawns ball if it falls out of bounds
        if(transform.position.y < -6f)
        {
            // Resets position to start position.
            transform.position = new Vector3(0, -3, 0);

            // Sets rotation to starting rotation.
            transform.rotation = Quaternion.Euler(0, 0, 0);

            // Resets the velocity to starting velocity.
            rb2d.velocity = transform.up * speed;
        }
    }
}
