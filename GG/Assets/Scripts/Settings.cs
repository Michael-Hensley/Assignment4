using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public Dropdown playerLives;
    public static int numLives = 1;
    public void selectLives()
    {
        switch (playerLives.value)
        {
            case 0:
            numLives = 1;
            Debug.Log(numLives);
            break;
            case 1:
            numLives = 2;
            Debug.Log(numLives);
            break;
            case 2:
            numLives = 3;
            Debug.Log(numLives);
            break;
            default:
            numLives = 1;
            Debug.Log(numLives);
            break;
        }
    }

    public InputField nameInput;
    public static string playerName = "Player";

    public void setPlayerName()
    {
        playerName = nameInput.text.ToString();
        Debug.Log(playerName);
    }

    public Slider rotationSpeedSlider;
    static public float rotationSpeed = 100;
    public Text rotationSpeedIndicator;

    public void setRotationSpeed()
    {
        switch (rotationSpeedSlider.value)
        {
            case 1:
            rotationSpeed = 50;
            rotationSpeedIndicator.text = rotationSpeed.ToString();
            Debug.Log(rotationSpeed);
            break;
            case 2:
            rotationSpeed = 100;
            rotationSpeedIndicator.text = rotationSpeed.ToString();
            Debug.Log(rotationSpeed);
            break;
            case 3:
            rotationSpeed = 150;
            rotationSpeedIndicator.text = rotationSpeed.ToString();
            Debug.Log(rotationSpeed);
            break;
        }
    }

    public Slider pinSpeedSlider;
    static public float pinSpeed = 20;
    public Text pinSpeedIndicator;

    public void setpinSpeed()
    {
        switch (pinSpeedSlider.value)
        {
            case 1:
            pinSpeed = 10;
            pinSpeedIndicator.text = pinSpeed.ToString();
            Debug.Log(pinSpeed);
            break;
            case 2:
            pinSpeed = 20;
            pinSpeedIndicator.text = pinSpeed.ToString();
            Debug.Log(pinSpeed);
            break;
            case 3:
            pinSpeed = 30;
            pinSpeedIndicator.text = pinSpeed.ToString();
            Debug.Log(pinSpeed);
            break;
        }
    }

    public Slider timeSlider;
    static public float timeToPlay = 40;
    public Text timeIndicator;

    public void setTheTime()
    {
        switch (timeSlider.value)
        {
            case 1:
            timeToPlay = 20;
            timeIndicator.text = timeToPlay.ToString();
            Debug.Log(timeToPlay);
            break;
            case 2:
            timeToPlay = 40;
            timeIndicator.text = timeToPlay.ToString();
            Debug.Log(timeToPlay);
            break;
            case 3:
            timeToPlay = 60;
            timeIndicator.text = timeToPlay.ToString();
            Debug.Log(timeToPlay);
            break;
        }
    }

}
