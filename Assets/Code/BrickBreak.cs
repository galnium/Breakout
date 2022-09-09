using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickBreak : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Destroys the impacted brick.
        Destroy(gameObject);
    }
}
