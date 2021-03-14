using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Game Started");
    }

    public void titleScreen()
    {
        SceneManager.LoadScene(0);
        Debug.Log("load intro");
    }
    public void exitGame()
    {
        Application.Quit();
        Debug.Log("Game exited");
    }
}
