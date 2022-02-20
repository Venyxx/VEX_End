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
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (PauseGame)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
       Cursor.lockState = CursorLockMode.Locked;
        //time scale was 0? -v
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
        PauseGame = false;
    }
    void Pause()
    {
        Cursor.lockState = CursorLockMode.None;
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
        PauseGame = true;
    }
    public void MainMenu()
    {
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }
    public void ExitGame()
    {
        Cursor.lockState = CursorLockMode.None;
        Debug.Log("you are quitten");
        Application.Quit();
    }
}
