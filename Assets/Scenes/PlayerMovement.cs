using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    private bool canJump;
    public float speed = 5.0f;
    public float jump_height = 4.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "FLOOR"){
            canJump = true;
        }
    }
    private void OnCollisionExit(Collision other) {
         if(other.gameObject.tag == "FLOOR"){
            canJump = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if ((canJump && Input.GetKey(KeyCode.Space)))
        {
            GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.up) * jump_height);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        { 
            transform.Translate(-1 * Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.W)) { 
            transform.Translate(Vector2.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);
        }
       

    }
    
}
