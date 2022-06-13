using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketMov : MonoBehaviour
{

    public int speed = 30;

    public Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        float Movment = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(Movment * speed, 0);

        
        Vector3 PlayerPos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        PlayerPos.z = 0f;
        PlayerPos.y = -3.23f;
        if (PlayerPos.x < -3.3f)
            PlayerPos.x = -3.3f;
        else if (PlayerPos.x > 3.45f)
            PlayerPos.x = 3.45f;
        transform.position = PlayerPos;

    }
}
