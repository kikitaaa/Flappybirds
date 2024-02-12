using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float jumpingForce = 4.5f; //Fuerza con la que saltara el player

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)) //Para que funcione en el movil utilizamos el parametro "touch"
         {
            Jump();

         }

        
    }

    void Jump()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, jumpingForce, 0); //Impulso que le da al Rigidbody
    }
}
