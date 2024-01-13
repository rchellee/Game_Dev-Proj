using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    
    public float jump;
    public bool isJumping;
    private float boostTimer;
    private float speedboost;
    private bool boosting;


    private Rigidbody2D rb;
    public float rotationSpeed = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        boosting = false;
        boostTimer = 0;
    }

    // Update is called once per frame

    void Update()
    {


        rb.velocity = new Vector2(speed, rb.velocity.y);
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow) && isJumping == false)

            if (Mathf.Abs(rb.velocity.x) > 0.1f)
            {
                RotateObjectAroundAxis();
            }

        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && isJumping == false)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
            isJumping = true;
        }
        if(boosting)
        {
            boostTimer += Time.deltaTime;
            if(boostTimer>=10)
            {
                speedboost = 15;
                boostTimer = 0;
                boosting = false;
            }
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="SpeedBoost")
        {
            boosting = true;
            speedboost = 20;
        }
    }

    private void RotateObjectAroundAxis()
    {
        transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))

            isJumping = false;
}
    }

