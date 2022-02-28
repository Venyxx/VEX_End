using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lamp : MonoBehaviour
{
    public GameObject lightobj;
    public Vector3 lightpointloc;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("noticed light");
        spawnLight();
    } 

    void spawnLight ()
    {
        Instantiate(lightobj, lightpointloc, Quaternion.identity);
        Debug.Log(lightpointloc);
    }
}
