using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
   
    
    public float speed = 30.0f;

    private Rigidbody playerRb;
    private float movementX; 
    private float movementY;

    private float size = 10;


    void Start()
    {
        playerRb = GetComponent<Rigidbody>();

    }

    void FixedUpdate()
    {
        //Get Input from keyboard or other devices
        float movementX = Input.GetAxis("Horizontal");
        float movementY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        playerRb.AddForce(movement * speed);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Prop") && collision.transform.localScale.magnitude <= size)
        {
            Debug.Log("OnCollisoinEnter");

            collision.transform.parent = transform;
            size += collision.transform.localScale.magnitude;
        }
    }
    
}
