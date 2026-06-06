using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce;
    public float sidewaysForce;
    // for all frames just use -> * Times.deltaTime
    // WHEN DOING physics and stuff use -> FixedUpdate()

    //public float forwardForce = 2000;

    // void Start()
    // {
        
    // }
    void FixedUpdate()
    {
        // rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
