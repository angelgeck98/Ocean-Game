using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
   

    public float speed = 30.0f;

    private Rigidbody playerRb;
    public float size = 10.0f;

    

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
        playerRb.AddForce(movement * speed, ForceMode.Acceleration);

    
    }

    void OnTriggerEnter(Collider other)
    {
    if(other.gameObject.CompareTag("Prop") && other.transform.localScale.magnitude <= size)
        {
        Debug.Log("OnTriggerEnter");

        // Turning off the colliders of the props
        Collider propCollider = other.gameObject.GetComponent<Collider>();
        if(propCollider != null)
        {
            propCollider.enabled = false;
        }

        // Make the objects child of the ball/player 
        other.transform.parent = transform;

        // Changing the size to reflect the number of stuff collected
        
        size += other.transform.localScale.magnitude;
        }


    }

}
    

