using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
//player config----------------------
public Transform player;
public float playerDistance;

//enemy config--------
public float awareAI = 50f;
public float aiMoveSpeed;
public float damping = 6.0f;



//navigation and location storage-------------
public Transform[] navPoint;
public UnityEngine.AI.NavMeshAgent agent;
public int destinationPoint = 0;
public Transform goal;


void Start ()
{
    UnityEngine.AI.NavMeshAgent agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    agent.destination = goal.position;
    agent.autoBraking = false;
}

void FixedUpdate ()
{
    playerDistance = Vector3.Distance (player.position, transform.position);

    if(playerDistance < awareAI)
    {
        //too close
        LookAtPlayer();
        Debug.Log("Spotted.loc.EnemyControl");
    }

    if(playerDistance < awareAI)
    {
        //far too close
        if (playerDistance > 10f)
        {
            Chase();
        } 
        //else 
            //goToNextPoint();
    }
        //turn this script on if you want him to go back to main behavior after 
    if (agent.remainingDistance < 9f)
       goToNextPoint();
}
void LookAtPlayer()
{
    transform.LookAt(player);
    Debug.Log("called look at");
}

void goToNextPoint ()
{
    if (navPoint.Length == 0)
        return;
    agent.destination = navPoint[destinationPoint].position;
    destinationPoint = (destinationPoint + 1) % navPoint.Length;
}

void Chase ()
 {
     transform.Translate (Vector3.forward * 2 * aiMoveSpeed * Time.deltaTime);
 }
}
