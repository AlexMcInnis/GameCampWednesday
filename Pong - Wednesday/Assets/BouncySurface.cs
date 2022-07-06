using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    public float bounceStrength;

    private void OnCollisionEnter2D(Collision2D coll)
    {
        BallMovement ball = coll.gameObject.GetComponent<BallMovement>();
        if(ball != null)
        {
            Vector2 normal = coll.GetContact(0).normal;
            ball.AddForce(-normal * this.bounceStrength);
        }
    }
}
