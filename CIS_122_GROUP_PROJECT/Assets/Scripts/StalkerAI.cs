using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StalkerAI : MonoBehaviour
{
    public GameObject stalkerDest;
    NavMeshAgent stalkerAgent;
    void Start()
    {
        stalkerAgent = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        stalkerAgent.SetDestination(stalkerDest.transform.position);
    }
}
