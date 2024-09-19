using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20f;
    private float turnSpeed = 45.0f;

    private float horizontalInput;
    private float forwardInput;

    void Start()
    {
        
    }
    
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime *speed);
        transform.Translate(Vector3.right *Time.deltaTime* turnSpeed);
        
        //moves car forward
        transform.Translate(Vector3.forward * Time.deltaTime *speed * forwardInput);

        //turns car horizontally
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

    }
}
