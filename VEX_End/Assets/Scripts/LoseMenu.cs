using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseMenu : MonoBehaviour
{

    public GameObject endUI;

    public void MainMenu()
    {
       
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }
    public void ExitGame()
    {
        
        Debug.Log("you are quitten");
        Application.Quit();
    }
}
