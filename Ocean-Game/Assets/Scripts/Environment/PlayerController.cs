using System;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
   

    public float speed = 30.0f;
    public float size = 1.0f;

    private Rigidbody _playerRb;

    

    void Start()
    {
        _playerRb = GetComponent<Rigidbody>();
        

    }

    void FixedUpdate()
    {
        //Get Input from keyboard or other devices
        var movementX = Input.GetAxis("Horizontal");
        var movementY = Input.GetAxis("Vertical");

        var movement = new Vector3(movementX, 0.0f, movementY);
        _playerRb.AddForce(movement * speed, ForceMode.Acceleration);

    
    }

    void OnTriggerEnter(Collider other)
    {
        //checks tag
        if(!other.gameObject.CompareTag("Prop")) return;
        
        //checks the actual size instead of the magnitude of the vector
        float objectSize = Mathf.Max(other.transform.localScale.x, other.transform.localScale.y, other.transform.localScale.z);
        
        //checks if size is less than or equal
        if (objectSize <= size)
        {
            Debug.Log("Player collision");
            
            var propCollider = other.gameObject.GetComponent<Collider>();

            if (propCollider != null)
            {
                propCollider.enabled = false;
            }
            
            //make child 
            other.transform.parent = transform;
            
            //change size variable
            size += objectSize;

            transform.localScale *= 1.09f;

        }

    }

}
    

