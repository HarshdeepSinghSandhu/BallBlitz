using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            Debug.Log("Collided");
            FindObjectOfType<Gamemanager>().Endgame();
        }
    }
    }

