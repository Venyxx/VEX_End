using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class plant : MonoBehaviour
{
    // Start is called before the first frame update
    void Start ()
    {
        Debug.Log("got flower script");
    }
    void OnCollisionEnter (Collision other)
    {
        Debug.Log("checking fro col");
        if (other.collider.tag == "Player")
        {
            Debug.Log("You won");
            SceneManager.LoadScene("WinScene");
            
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("WinScene");
    } 
}
