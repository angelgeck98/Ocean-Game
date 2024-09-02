using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody playerRb;
    public float speed = 350.0f;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");
        float forwardInput = Input.GetAxis("Vertical");

        playerRb.AddForce(transform.forward * speed * Time.deltaTime * forwardInput);
        playerRb.AddForce(transform.right * speed * Time.deltaTime * HorizontalInput);

    }
}
