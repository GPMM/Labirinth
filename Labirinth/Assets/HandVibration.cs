using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;


public class HandVibration : MonoBehaviour
{
    public Rigidbody rb;
    private bool isColliding=false;
    public XRBaseController controller;

    void Update()
    {
        if (isColliding){
            print("Esta tocando");
            controller.SendHapticImpulse(0.9f, 10);
        } else
        {
            
            print("Parou de tocar");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Osbtacle"))
        {   
            isColliding=true;
            controller.SendHapticImpulse(0.9f, 1);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Osbtacle"))
        {
            isColliding=false;
            controller.SendHapticImpulse(0, 0);
        }
    }
}