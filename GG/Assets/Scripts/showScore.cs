using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showScore : MonoBehaviour
{
    public Text scoreBox;
    void Start()
    {
        scoreBox.text = Score.PinCount.ToString();
    }
}
