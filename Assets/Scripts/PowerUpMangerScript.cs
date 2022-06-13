using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpMangerScript : MonoBehaviour
{
    // Start is called before the first frame update
    bool TimesThree = false;
    bool PlusThree = false;
    float Timerp1 = 0;
    float Timerp2 = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(TimesThree)
        {
            Timerp1 += Time.deltaTime; 
            if((int)Timerp1==5)
            {
                TimesThree = false;
            }
        }
        else
        {
            GameObject.Find("Ball").GetComponent<BallMov>().SetSpeed(8);
            Timerp1 = 0;
        }
        if (PlusThree)
        {
            Timerp2 += Time.deltaTime;
            if ((int)Timerp2 == 5)
            {
                PlusThree = false;
            }
        }
        else
        {
            GameObject.Find("Racket").GetComponent<RacketMov>().transform.localScale = new Vector3(4.576f, 3.360586f,1f);
            Timerp2 = 0;
        }

    }
    public void SetTimesThree(bool TimesThree)
    {
        this.TimesThree = TimesThree;    
    }
    public void SetPlusThree(bool PlusThree)
    {
        this.PlusThree = PlusThree;
    }
}
