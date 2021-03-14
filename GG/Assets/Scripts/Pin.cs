using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pin : MonoBehaviour {

	private bool isPinned = false;
	private bool isColliding = false;
	public Rigidbody2D rb;

	void Update ()
	{
		if (!isPinned)
			rb.MovePosition(rb.position + Vector2.up * Settings.pinSpeed * Time.deltaTime);
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.tag == "Rotator")
		{
			transform.SetParent(col.transform);
			Score.PinCount++;
			isPinned = true;
		} 
		else if (col.tag == "Pin")
		{
			if(isColliding == false)
			{
				isColliding = true;
				Settings.numLives--;
				if(Settings.numLives < 0)
        		{
            		SceneManager.LoadScene(2);
             		Debug.Log("Game Over");
					Debug.Log(Settings.numLives);
        		}
			}
			
		}
	}

}
