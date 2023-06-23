using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
public Rigidbody rb;

    
public float MovForce = 500f;

    // Update is called once per frame
    void Update()
    {
     
       if(Input.GetKey("w"))
       {
         rb.AddForce(0,0,MovForce * Time.deltaTime);
       }

       if(Input.GetKey("s"))
       {
         rb.AddForce(0,0,-MovForce * Time.deltaTime);
       }

       if(Input.GetKey("d"))
       {
        rb.AddForce(MovForce * Time.deltaTime,0,0);
       }

        if(Input.GetKey("a"))
       {
        rb.AddForce(-MovForce * Time.deltaTime,0,0);
       }
    }
}
