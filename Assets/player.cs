using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    
    public float speedP= 5.0f;
    public ball Ball;
    void Start()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            Ball.Addforce();
        }
    }
    void Update()
    {
        Vector3 moveX = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.Translate(moveX * speedP * Time.deltaTime);
        if (transform.position.x >= 9.96f)
        {
            transform.position = new Vector3(-9.99f, -4.57f, -0.02303443f);
        }
        else if (transform.position.x <= -9.96f)
        {
            transform.position = new Vector3(9.99f, -4.57f, -0.02303443f);
        }


       
    }
}
