using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flee : MonoBehaviour {


    Rigidbody rb; 			// The Rigidbody on which to apply force to

    Vector3 desiredVelocity; 		// the desired direction and speed in which to move

    public float speed; 			// How fast we will go

    public GameObject Target;       //What object are we moving towards?

    void Start()
    {

        rb = GetComponent<Rigidbody>();
        // assigning the Rigidbody we are adding force to, 
        //  to the rigidbody attached to this object
    }

    void Update()
    {
        desiredVelocity = -speed * (Target.transform.position - transform.position).normalized;
        //Calculating the directional normalized vector
        // between OUR position and the TARGETs position
        //Then multiplying it by our speed


        rb.AddForce(desiredVelocity - rb.velocity);
        //Subtracting our velocity from our force
        // provides us with a smoother acceleration
        //and maintainment of our speed

    }
}
