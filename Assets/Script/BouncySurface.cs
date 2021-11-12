using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    public float bounceStrength;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Ball ball = collision.gameObject.GetComponent<Ball>();

        if (collision.gameObject.tag=="Ball")
        {
            Rigidbody2D ball = collision.gameObject.GetComponent<Rigidbody2D>();
            Vector2 normal = collision.GetContact(0).normal;
            
            if (ball.velocity.x >= 0.0f && ball.velocity.x < 6.0f)
            {
                ball.AddForce(-normal * 100 );
            }
            if (ball.velocity.x < 0.0f && ball.velocity.x > -6.0f)
            {
                ball.AddForce(-normal * 100);
            }
            if (ball.velocity.y >= 0.0f && ball.velocity.y < 6.0f)
            {
                Vector2 dir = new Vector2(0, 1);
                ball.AddForce(dir* 50);
            }
            if (ball.velocity.y < 0.0f && ball.velocity.y > -6.0f)
            {
                Vector2 dir = new Vector2(0, -1);
                ball.AddForce(dir * 50);
            }
            else
            {
                ball.AddForce(-normal * this.bounceStrength);
            }
            
            



        }
    }

}
