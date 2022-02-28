using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lamp : MonoBehaviour
{
    public GameObject lightobj;
    public GameObject lightpointloc;
    private void OnTriggerEnter(Collider other)
    {
        var theLocation = transform;
        Instantiate(lightobj, theLocation.position, Quaternion.identity);
        Debug.Log(lightpointloc);
        Debug.Log("noticed light");
        
    } 

 
}
