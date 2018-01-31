using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pathmesh : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
bool pathComplete()
{
    if (!agent.pathPending)
    {
        if (agent.stoppingDistance >= agent.remainingDistance)
        {
            if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
            {
                return true;
            }
        }
    }
    return false;
}