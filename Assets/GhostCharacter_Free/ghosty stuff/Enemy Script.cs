using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;
using Range = UnityEngine.SocialPlatforms.Range;

public class EnemyScript : MonoBehaviour
{
    private Vector3 startPosition;  //Give it a startPosition so it knows where it's 'home' location is.
    private bool wandering = true;  //Set a bool or state so it knows if it's wandering or chasing a player
    private bool chasing = false;
    private float wanderSpeed = 5.5f;  //Give it the movement speeds
    private GameObject target;  //The target you want it to chase

    private NavMeshAgent agent;
    // Start is called before the first frame update
    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = wanderSpeed;
        startPosition = this.transform.position;
        
        InvokeRepeating("Wander", 1f, 10f);
    }

    private void Wander()
    {
        Vector3 destination = startPosition + new Vector3(Random.Range(-wanderSpeed, wanderSpeed), 0,
            Random.Range(-wanderSpeed, wanderSpeed));
        NewDestination(destination);
    }

    public void NewDestination(Vector3 targetPoint)
    {
        agent.SetDestination(targetPoint);
    }
    void Start()
    {
         agent = GetComponent<NavMeshAgent>();
         agent.speed = wanderSpeed;
         startPosition = this.transform.position;
         
         InvokeRepeating("Wander", 1f, 10f);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
