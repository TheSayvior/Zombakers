using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBehavior : MonoBehaviour {

    Vector3 playerPos;

    NavMeshAgent agent;

    void Awake()
    { 
        playerPos = GameObject.FindGameObjectWithTag("Player").transform.position;
        NavMeshAgent agent = GetComponent<NavMeshAgent>();

        agent.destination = playerPos;
    }
	
	
}
