using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {
	public float speed = Settings.rotationSpeed;
	void Update ()
	{
		transform.Rotate(0f, 0f, Settings.rotationSpeed * Time.deltaTime);
	}

}
