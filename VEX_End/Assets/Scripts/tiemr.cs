using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class tiemr : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI TimerDisplay;
    
float timer = 90;
int randomBoy;

    void Start()
    {
        timer = 90;
        
        Timerprinting();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (timer < 1)
        {
            SceneManager.LoadScene("LoseScene");
        }
        timer -= Time.deltaTime;
         randomBoy = Random.Range(0, 100);
        Timerprinting();
        Debug.Log(randomBoy);


    }
     public void Timerprinting()
    {
        
        TimerDisplay.text = "TIME LEFT: " + timer.ToString();
        
        
    }
}
