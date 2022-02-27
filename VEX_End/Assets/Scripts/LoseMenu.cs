using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseMenu : MonoBehaviour
{

    public GameObject endUI;

    void Start ()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
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
