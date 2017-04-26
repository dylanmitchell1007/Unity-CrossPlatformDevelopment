using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehaviour : MonoBehaviour {
    public float jump;
    public float speed;
    private Rigidbody rb;
    private Rigidbody jp;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        jp = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            
        }

        float jumpup = Input.GetAxis("Horizontal");
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        Vector3 getjump = new Vector3(jumpup, 0.0f, moveHorizontal);
        
        jp.AddForce(getjump * speed);
        rb.AddForce(movement * speed);
    }
}
