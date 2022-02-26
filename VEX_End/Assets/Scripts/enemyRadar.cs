using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyRadar : MonoBehaviour
{
     int mask = (1 << 7);
    void Update()
    {
        RaycastHit hit;
        
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, mask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * Mathf.Infinity, Color.yellow);
            //Debug.Log("Hit");
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            //Debug.Log("No Hit");
        }


    }
}
