using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum States
{
    WanderState,
    arriveState,
    fleeState,
    startoverState
}

public class StateMachine : MonoBehaviour {

    NavMeshAgent agent;
    WanderBehavior wander;
    ArriveBehavior arrive;
    Flee flee;
    States currentState;

    public float transitionTime;
    float timer;

	// Use this for initialization
	void Start () {
        timer = transitionTime;
        agent = GetComponent<NavMeshAgent>();
        wander = GetComponent<WanderBehavior>();
        arrive = GetComponent<ArriveBehavior>();
        flee = GetComponent<Flee>();
     
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
