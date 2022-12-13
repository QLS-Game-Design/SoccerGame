using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerBall : MonoBehaviour
{
    public float speed = 5f;
    
 
 private void OnCollisionEnter (Collision other)
     {
     if(other.gameObject.tag == "Player1")
         {
         GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * speed );
         Debug.Log("Ball Kicked");
         }
         if(other.gameObject.tag == "Player2")
         {
         GetComponent<Rigidbody>().AddForce(transform.TransformDirection(-Vector3.forward) * speed );
         Debug.Log("Ball Kicked");
         }
         
            
         }
     }



