using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{

    public GameObject Ball;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        

    // Update is called once per frame
    void Update()
    {
    Ball.GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward * speed));

    }
    }
}
