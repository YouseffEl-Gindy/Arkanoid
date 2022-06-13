using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimesThreePower : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject ball;
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.down *3;
        ball = GameObject.Find("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y<-5.4f)
        {
            Destroy(gameObject);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            ball.GetComponent<BallMov>().SetSpeed(16);
            GameObject.Find("PowerUpManger").GetComponent<PowerUpMangerScript>().SetTimesThree(true);
            Destroy(gameObject);
        }
       
    }
}
