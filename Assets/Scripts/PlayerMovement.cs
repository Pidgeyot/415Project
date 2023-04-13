using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    
    void Start()
    {
        speed = 25f;
    }
    

    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow))
        {
            pos.z += speed * Time.deltaTime;
        }
        if (Input.GetKey("s") || Input.GetKey(KeyCode.DownArrow))
        {
            pos.z -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= speed * Time.deltaTime;
        }


        transform.position = pos;

        //if player collides with ocean and egg counter is full, level is over and won

        //if player collides with seagull, level is over and lost

    }
}
