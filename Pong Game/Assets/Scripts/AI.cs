using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public float speed = 10.0f;

    public Rigidbody2D ball;

    protected Rigidbody2D _rigidbody;


    private void FixedUpdate()
    {

        if(this._rigidbody.velocity.x > 0.0f)
        {

            if(this.ball.position.y > this.transform.position.y)
            {

                _rigidbody.AddForce(Vector2.up * this.speed);
            }  else if (this.ball.position.y < this.transform.position.y)
            {
                _rigidbody.AddForce(Vector2.down * this.speed);
            }

        }

        else
        {
            if(this.transform.position.y > 0.0f) {
                _rigidbody.AddForce(Vector2.down * this.speed);
            }else if(this.transform.position.y < 0.0f)
            {

                _rigidbody.AddForce(Vector2.up * this.speed);
            }
        }
    }
    
}
