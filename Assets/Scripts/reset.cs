using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour
{
    Vector2 startPosition;
    Quaternion startRotation;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        startPosition = transform.position;
        startRotation = transform.localRotation;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -6 || Input.GetButtonDown("Fire1"))
        {
            transform.position = startPosition;
            transform.rotation = startRotation;

            rb.gravityScale = 0;
            rb.velocity = Vector2.zero; 
            rb.angularVelocity = 0;
        }
    }
}
