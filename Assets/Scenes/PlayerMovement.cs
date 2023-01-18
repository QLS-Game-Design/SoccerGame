using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    private bool canJump;
    public float speed = 5.0f;
    public float jump_height = 4.0f;
    public int playerNum;

    //private KeyCode upKey;
    //private KeyCode downKey;
    //private KeyCode leftKey;
    //private KeyCode rightKey;
    private KeyCode jumpKey;
    private string inputAxisHorizontal;
    private string inputAxisVertical;

    private Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        if (playerNum == 1)
        {
            //upKey = KeyCode.W;
            //downKey = KeyCode.S;
            //leftKey = KeyCode.A;
            //rightKey = KeyCode.D;
            inputAxisHorizontal = "Player1Horizontal";
            inputAxisVertical = "Player1Vertical";
            jumpKey = KeyCode.Space;
        }
        else if (playerNum == 2)
        {
            //upKey = KeyCode.UpArrow;
            //downKey = KeyCode.DownArrow;
            //leftKey = KeyCode.LeftArrow;
            //rightKey = KeyCode.RightArrow;
            inputAxisHorizontal = "Player2Horizontal";
            inputAxisVertical = "Player2Vertical";
            jumpKey = KeyCode.RightShift;
        }
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
    void FixedUpdate()
    {
        if ((canJump && Input.GetKey(jumpKey)))
        {
            GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.up) * jump_height);
        }

        Vector3 v = new Vector3(Input.GetAxisRaw(inputAxisVertical), 0, Input.GetAxisRaw(inputAxisHorizontal)).normalized * Time.deltaTime * speed;
        v.y = rb.velocity.y;
        rb.velocity = v;

        //if (Input.GetKey(rightKey) && transform.position.x < 1)
        //{
        //    Vector3 v = Vector3.forward * Time.deltaTime * speed;
        //    v.y = rb.velocity.y;
        //    rb.velocity = v;
        //    // transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //}
        //if (Input.GetKey(leftKey))
        //{
        //    Vector3 v = -1 * Vector3.forward * Time.deltaTime * speed;
        //    v.y = rb.velocity.y;
        //    rb.velocity = v;
        //    // transform.Translate(-1 * Vector3.forward * Time.deltaTime * speed);
        //}
        //if (Input.GetKey(upKey)) 
        //{
        //    Vector3 v = Vector2.left * Time.deltaTime * speed;
        //    v.y = rb.velocity.y;
        //    rb.velocity = v;
        //    // transform.Translate(Vector2.left * Time.deltaTime * speed);
        //}
        //if (Input.GetKey(downKey))
        //{
        //    Vector3 v = Vector2.right * Time.deltaTime * speed;
        //    v.y = rb.velocity.y;
        //    rb.velocity = v;
        //    // transform.Translate(Vector2.right * Time.deltaTime * speed);
        //}

        //if (!Input.GetKey(upKey) && !Input.GetKey(downKey) && !Input.GetKey(leftKey) && !Input.GetKey(rightKey))
        //{
        //    Vector3 v = new Vector3(0, 0, 0);
        //    v.y = rb.velocity.y;
        //    rb.velocity = v;
        //}

    }
    
}
