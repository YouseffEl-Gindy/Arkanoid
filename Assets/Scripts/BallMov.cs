using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMov : MonoBehaviour
{
    public int speed = 100;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
       
    }
    float HitFactor(float BallX,float RacketX,float racketheight)
    {
        return (BallX - RacketX) / racketheight;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Racket")
        {
            float BallX = transform.position.x;
            float RacketX = collision.transform.position.x;
            float racketHeight = collision.collider.bounds.size.x;

            float hit = HitFactor(BallX, RacketX, racketHeight);
            Vector2 Dir = new Vector2(hit, 1).normalized;
            GetComponent<Rigidbody2D>().velocity = Dir * speed;
        }
    }
    public void StartAgain()
    {
        transform.position =new Vector2(0, -2.74f);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * speed;

    }
    public void SetSpeed(int speed)
    {
        this.speed = speed; 
    }

}
