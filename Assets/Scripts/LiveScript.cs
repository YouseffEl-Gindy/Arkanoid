using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LiveScript : MonoBehaviour
{
    public TextMeshProUGUI LiveText;
    public TextMeshProUGUI GameOverText;
    int lives = 3;

    bool GameOver = false;
    
    // Start is called before the first frame update
    void Start()
    {
        LiveText.text = "Lives: " + lives;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void LiveDown()
    {
        lives--;
    }
    private void FixedUpdate()
    {
        float BallY = GameObject.Find("Ball").transform.position.y;
        if (BallY < -5.4)
        {
            lives--;
            if (!(lives < 0))
            {
                GameObject.Find("Ball").GetComponent<BallMov>().StartAgain();
                
            }
            else
                GameOver = true;

        }
        if (!GameOver)
            LiveText.text = "Lives: " + lives;
        else
            GameOverText.text = "Game Over";
    }
}
