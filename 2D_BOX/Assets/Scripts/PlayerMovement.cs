using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private float move;
    public float jump;
    public bool isJumping;

    private Rigidbody2D rb;
    public float rotationSpeed = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
    
        rb.velocity = new Vector2(speed, rb.velocity.y);

        if (Mathf.Abs(rb.velocity.x) > 0.1f)
        {
            RotateObjectAroundAxis();
        }

        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && isJumping == false)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
            isJumping = true;
        }
    }

    private void RotateObjectAroundAxis()
    {
        transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }
}