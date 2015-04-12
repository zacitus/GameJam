using System.Collections;
using UnityEngine;

public class GetInput : MonoBehaviour {

	// Keycode Constants
	public static KeyCode moveUpKey  	= KeyCode.W;
	public static KeyCode moveLeftKey  	= KeyCode.A;
	public static KeyCode moveDownKey 	= KeyCode.S;
	public static KeyCode moveRightKey  = KeyCode.D;

	// Controller variables
	public float moveX;
	public float moveY;
	public float deadzone = .15f; // Deadzone is for joysticks that aren't perfect
	
	// Update is called once per frame
	void Update () 
	{
		GetControllerValues();
	}

	// Get the controller values
	void GetControllerValues () 
	{
		moveX = Input.GetAxis("Horizontal");
		moveY = Input.GetAxis("Vertical");

		// Sets movement to 0 if the controller value is inside the deadzone
		if (moveX > 0 && moveX < deadzone)
		{
			moveX = 0;
		}

		if (moveX < 0 && moveX > -deadzone)
		{
			moveX = 0;
		}

		if (moveY > 0 && moveY < deadzone)
		{
			moveY = 0;
		}
		
		if (moveY < 0 && moveY > -deadzone)
		{
			moveY = 0;
		}
	}
}
