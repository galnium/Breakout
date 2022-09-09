using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMove : MonoBehaviour
{
    // Modifiable in inspector in Unity
    public float speed = 5;

    private Rigidbody2D rb2d;

    void Start()
    {
        // Automatically sets the Rigidbody2D variable without needing to do so in Unity.
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // Gets horizontal input from player, by default reads a/d and left/right arrows.
        // Can be modified in Edit > Project Settings > Input Manager.
        float horizontal = Input.GetAxis("Horizontal") * speed * 100 * Time.deltaTime;

        // Applies to the Rigidbody2D's velocity.
        rb2d.velocity = new Vector2 (horizontal, 0);
    }
}
