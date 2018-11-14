using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed;
    public float torque;

    private Rigidbody rb;

    public VirtualJoystick moveJoystick;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        /* Code for movement -> remove this later
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
        */

        /* Code for VirtualJoystick -> Adapt to code for snowboarding game
        Vector3 dir = Vector3.zero;

        dir.y = Input.GetAxis ("Horizontal");
        dir.x = Input.GetAxis ("Vertical");

        if (dir.magnitude > 1)
        {
            dir.Normalize();   
        }

        if (moveJoystick.InputDirection != Vector3.zero)
        {
            dir = moveJoystick.InputDirection;
        }

        rb.AddTorque(transform.right * torque * dir.y);
        rb.AddTorque(transform.up * torque * dir.x);
        */

        
        float turn_v = Input.GetAxis("Vertical");

        rb.AddTorque(transform.right * torque * turn_v);

        float turn_h = Input.GetAxis("Horizontal");

        rb.AddTorque(transform.up * torque * turn_h);
        

        // Jump

    }

    // Update is called once per frame
    void Update () {
		
	}
}
