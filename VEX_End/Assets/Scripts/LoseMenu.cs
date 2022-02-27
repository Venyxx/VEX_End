using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseMenu : MonoBehaviour
{

    public GameObject endUI;

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
