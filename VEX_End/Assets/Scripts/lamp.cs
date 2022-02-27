using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lamp : MonoBehaviour
{
    public GameObject lightobj;
    public Vector3 lightpointloc;
    void OnCollisionEnter (Collision other)
    {
       
       if (other.collider.tag == "Player")
        {
         Debug.Log ("noticed light hit");
         spawnLight();   
        }
        
    }

    void spawnLight ()
    {
        Instantiate(lightobj, lightpointloc, Quaternion.identity);
        Debug.Log(lightpointloc);
    }
}
