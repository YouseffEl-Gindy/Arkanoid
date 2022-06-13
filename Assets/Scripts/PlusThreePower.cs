using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlusThreePower : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.down *3;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5.4f)
        {
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.localScale = new Vector3(2.7f, 3.360586f, 1f);
            GameObject.Find("PowerUpManger").GetComponent<PowerUpMangerScript>().SetPlusThree(true);
            Destroy(gameObject);
        }
    }
}
