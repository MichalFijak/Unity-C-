using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardforce = 2000;
    public float slideforce = 200;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // ad a forward force
        rb.AddForce(forwardforce * Time.deltaTime, 0, 0);
        
        if ( Input.GetKey("a"))
        {
            rb.AddForce(0,0,Time.deltaTime * slideforce,ForceMode.VelocityChange);

        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(0, 0,(-Time.deltaTime * slideforce), ForceMode.VelocityChange);

        }
        if(rb.position.y<(-1f))
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
