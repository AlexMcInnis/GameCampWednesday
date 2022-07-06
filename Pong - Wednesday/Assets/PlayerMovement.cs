using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    private Rigidbody2D rb;
    private Vector2 dir;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
       if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            dir = Vector2.up;
        }
       else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            dir = Vector2.down;
        }
        else
        {
            dir = Vector2.zero;
        }
    }
    private void FixedUpdate()
    {
        if(dir.sqrMagnitude != 0)
        {
            rb.AddForce(dir * speed);
        }
    }
    public void ResetPosition()
    {
        rb.position = new Vector2(rb.position.x, 0.0f);
        rb.velocity = Vector2.zero;
    }
}
