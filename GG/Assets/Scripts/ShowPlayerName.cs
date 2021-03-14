using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPlayerName : MonoBehaviour
{
    public Text thePlayerName;
    public Text playerLivess;
    void Start()
    {
        thePlayerName.text = Settings.playerName;
        playerLivess.text = Settings.numLives.ToString();
    }
}
