using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // when audio is implemented can deafen with function 
    public static bool PauseGame = false;
   
    public GameObject pauseUI; 

    // Update is called once per frame
    void Update()   {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(PauseGame)
            {
                Resume();
            } else 
        {
            Pause();
        }
    }
}
public void Resume ()
{
pauseUI.SetActive(false);
Time.timeScale = 0f;
PauseGame = false;
}
void Pause ()
{
pauseUI.SetActive(true);
Time.timeScale = 0f;
PauseGame = true;
}
public void MainMenu()
{
    Time.timeScale = 1f;
SceneManager.LoadScene("MainMenu");
}
public void ExitGame()
{
Debug.Log("you are quitten");
Application.Quit();
}
}
