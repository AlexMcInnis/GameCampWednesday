using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody2D ball;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
       if(ball.velocity.x > 0f)
        {
            if(ball.position.y > this.transform.position.y)
            {
                rb.AddForce(Vector2.up * speed);
            }
            else if(ball.position.y < this.transform.position.y)
            {
                rb.AddForce(Vector2.down * speed);
            }
        }
        else
        {
            if(transform.position.y > 0f)
            {
                rb.AddForce(Vector2.down * speed);
            }else if(transform.position.y < 0f)
            {
                rb.AddForce(Vector2.up * speed);
            }
        }
    }
    public void ResetPosition()
    {
        rb.position = new Vector2(rb.position.x, 0.0f);
        rb.velocity = Vector2.zero;
    }
}
