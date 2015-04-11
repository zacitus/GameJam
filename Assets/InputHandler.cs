using System.Collections;
using UnityEngine;

public class InputHandler : MonoBehaviour {

	// these are the keys that we will reference for the pc yeah man
	public static KeyCode moveUpKey  	= KeyCode.W;
	public static KeyCode moveLeftKey  	= KeyCode.A;
	public static KeyCode moveDownKey 	= KeyCode.S;
	public static KeyCode moveRightKey  = KeyCode.D;

	// this is the thing for the controller variables
	public float moveX;
	public float moveY;
	public float deadzone = .25f;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () 
	{
		GetControllerValues();

		//testing shit
		Debug.Log(moveX);
	}


	// Gets the controller values and saves them into values so we can use them
	// also deadzone checking
	void GetControllerValues () 
	{
		moveX = Input.GetAxis("Horizontal");
		moveY = Input.GetAxis("Vertical");

		// deadzone checking
		// this makes sure the controller value is deadzone compliant
		// just sets it to zero if it falls in the deadzone
		if (moveX > 0 && moveX < deadzone)
		{
			moveX = 0;
		}

		else if (moveX < 0 && moveX > -deadzone)
		{
			moveX = 0;
		}

		if (moveY > 0 && moveY < deadzone)
		{
			moveY = 0;
		}
		
		else if (moveX < 0 && moveY > -deadzone)
		{
			moveY = 0;
		}
	}
}
