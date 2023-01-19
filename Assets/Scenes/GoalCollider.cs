using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalCollider : MonoBehaviour
{
    public GameObject ball;
    public GameObject player1;
    public GameObject player2;

    private Vector3 player1Start;
    private Vector3 player2Start;
    private Vector3 ballStart;
    
    // Start is called before the first frame update
    void Start()
    {
        player1Start = player1.transform.position;
        player2Start = player2.transform.position;
        ballStart = ball.transform.position;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "BALL"){
            Debug.Log("SCORE");
            ball.transform.position = ballStart;
            // ball.transform.position = Vector3.left;
            ball.transform.rotation = Quaternion.identity;
            ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
            
            player1.transform.rotation = Quaternion.identity;
            player1.transform.position = player1Start;
            // player1.transform.position = new Vector3(0.501464844f,0.430000305f,-9.26629353f);
            player1.GetComponent<Rigidbody>().velocity = Vector3.zero;

            player2.transform.rotation = Quaternion.identity;
            player2.transform.position = player2Start;
            // player2.transform.position = new Vector3(0.501464844f,0.430000305f,8.35370636f);
            player2.GetComponent<Rigidbody>().velocity = Vector3.zero;
            
            

        }

    }
}
