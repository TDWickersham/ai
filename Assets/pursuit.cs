using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pursuit : MonoBehaviour {

    Rigidbody rb;
    Rigidbody targetRb;
    Vector3 desiredVelocity;
    Vector3 projectedPosition;
    public float speed;
    public Transform target;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        targetRb = target.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        projectedPosition = target.position + targetRb.velocity;
        desiredVelocity = speed * (projectedPosition - transform.position).normalized;
        rb.AddForce(desiredVelocity - rb.velocity);
	}
}
