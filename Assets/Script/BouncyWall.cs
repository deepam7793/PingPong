using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyWall : MonoBehaviour
{
    public float bounceWall;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Ball ball = collision.gameObject.GetComponent<Ball>();

        if (collision.gameObject.tag == "Ball")
        {
            
            Rigidbody2D ball = collision.gameObject.GetComponent<Rigidbody2D>();
            Vector2 normal = collision.GetContact(0).normal;

            //ball.AddForce(-normal * this.bounceWall);
            //Vector3 direction = // an arbitrary direction (any normalized vector)
            //float speedInThatDirection = Vector3.Dot(rigibody.velocity, direction);
            
            //Debug.Log(ball.velocity.y);
            if (ball.velocity.y>=0.0f && ball.velocity.y<6.0f)
            {
                ball.AddForce(-normal * this.bounceWall);
            }
            if(ball.velocity.y < 0.0f && ball.velocity.y > -6.0f)
            {
                ball.AddForce(-normal * this.bounceWall);
            }
            if (ball.velocity.x >= 0.0f && ball.velocity.x < 6.0f)
            {
                Vector2 dir = new Vector2(1, 0);
                ball.AddForce(dir* 50);
            }
            if (ball.velocity.x < 0.0f && ball.velocity.x > -6.0f)
            {
                Vector2 dir = new Vector2(-1, 0);
                ball.AddForce(dir*50);
            }



        }
    }
}
