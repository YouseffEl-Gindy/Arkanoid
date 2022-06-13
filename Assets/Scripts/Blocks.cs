using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    public GameObject TimesThree;
    public GameObject PlusThree;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        GameObject.Find("ScoreManger").GetComponent<Score>().AddScore();
        
        int randy = Random.Range(0, 10);
        if (randy != 5)
        {
            int selectPower = Random.Range(1, 3);
            if(selectPower == 1)
                Instantiate(TimesThree, transform.position, Quaternion.identity);
            else
                Instantiate(PlusThree, transform.position, Quaternion.identity);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name=="Ball")
        {
            
        }
    }
}
