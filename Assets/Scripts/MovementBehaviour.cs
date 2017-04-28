using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehaviour : MonoBehaviour {
    public float speed;
    private Rigidbody rb;
    private Rigidbody jp;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }
    void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Rigidbody>().velocity = transform.forward;
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            GetComponent<Rigidbody>().velocity = -transform.forward;
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<Rigidbody>().velocity = -transform.right;
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            GetComponent<Rigidbody>().velocity = transform.right;
        }
    }
}
