using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyRadar : MonoBehaviour
{
    public GameObject lastHit;
    public Vector3 collision = Vector3.zero;
    public LayerMask layer;
    public Rigidbody rigidbodyHere;
    public Vector3 lookdirection;

    void Start ()
    {
        rigidbodyHere = GetComponent<Rigidbody>();
    }
    void Update()
    {
        /*RaycastHit hit = Physics.Raycast(rigidbodyHere.position, lookDirection, 100f, LayerMask.GetMask("Enemy"));
            if (hit.collider.tag == "Player")
            {
                PlayerMovement character = hit.collider.GetComponent<PlayerMovement>();
                if (character != null)
                {
                    Debug.Log("noticed player");
                    
                }
            }
            */
    }
}
