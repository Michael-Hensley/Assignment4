using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{

    public Text timertxt;
    float timeLeft = Settings.timeToPlay;

    void Update()
    {
        timertxt.text = Mathf.Round(timeLeft).ToString();
        timeLeft -= Time.deltaTime;

         if(timeLeft < 0)
         {
             SceneManager.LoadScene(2);
             Debug.Log("Game Over");
         }
    }
}