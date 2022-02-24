using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void GameStart ()
   {
SceneManager.LoadScene("GameScene");
   }
    public void CreditsMenu ()
   {
SceneManager.LoadScene("Credits");
   }
public void ExitGame ()
{
    Debug.Log("you are quitten");
    Application.Quit();
}
}
