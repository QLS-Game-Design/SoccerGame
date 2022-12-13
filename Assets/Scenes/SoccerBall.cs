using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerBall : MonoBehaviour
{
    public float speed = 5f;
    
 
 void OnTriggerEnter (Collider col)
     {
     if(col.tag == "Player")
         {
         GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * speed );
         Debug.Log("Ball Kicked");
         }
     }
}

