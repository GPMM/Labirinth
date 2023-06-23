using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

 

public class gamereset : MonoBehaviour
{
    public float treshold = -10f;
    public Rigidbody rb;


    void Update()
    {
        if(transform.position.y < treshold)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Osbtacle"))
        {   
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);  
        }
    }
 }

