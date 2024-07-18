using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce;
    public float sideForce;

    private void FixedUpdate()
    {
        rb.AddForce(0, 0, -forwardForce * Time.deltaTime);

        if(Input.GetKey("a"))
        {
            //Move Right
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

         if(Input.GetKey("d"))
        {
            //Move Left
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        
        }
        if(rb.position.y < -1f)
        {
            FindObjectOfType<Gamemanager>().Endgame();
        }
    }

}
