using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    //public GameObject player; 
    //private Vector3 offset; 

    //Start is called before the first frame update
    void Start()
    {
        //offset = transform.position - player.transform.position;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        
    }

    //Update is called once per frame
    void LateUpdate()
    {
        //transform.position = player.transform.position + offset;
        Debug.Log("Cursor Lock State: " + Cursor.lockState);
        Debug.Log("Cursor Visible: " + Cursor.visible);
    }
}
