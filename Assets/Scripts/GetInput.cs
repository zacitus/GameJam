using System.Collections;
using UnityEngine;

public class GetInput : MonoBehaviour {

	#region Player 1 controller variables
	public float p1_leftStickX;
	public float p1_leftStickY;

	public float p1_rightStickX;
	public float p1_rightStickY;

	public float p1_leftTrigger = -1;
	public float p1_rightTrigger = -1;

	public bool p1_leftBumper;
	public bool p1_rightBumper;

	public bool p1_leftDpad;
	public bool p1_rightDpad;
	public bool p1_upDpad;
	public bool p1_downDpad;

	public bool p1_AButton;
	public bool p1_BButton;
	public bool p1_XButton;
	public bool p1_YButton;
	#endregion

	#region Player 2 controller variables
	public float p2_leftStickX;
	public float p2_leftStickY;

	public float p2_rightStickX;
	public float p2_rightStickY;

	public float p2_leftTrigger;
	public float p2_rightTrigger;
	
	public bool p2_leftBumper;
	public bool p2_rightBumper;
	
	public bool p2_leftDpad;
	public bool p2_rightDpad;
	public bool p2_upDpad;
	public bool p2_downDpad;
	
	public bool p2_AButton;
	public bool p2_BButton;
	public bool p2_XButton;
	public bool p2_YButton;
	
	public float deadzone = .5f; // Deadzone is for joysticks that aren't perfect
	#endregion

	void Update () 
	{
		GetStickValues();
		GetButtonValues();
		GetTriggerValues();
	}
	 
	void GetStickValues () 
	{
		#region Get player 1 input
		p1_leftStickX = Input.GetAxis("Horizontal");
		p1_leftStickY = Input.GetAxis("Vertical");

		p1_rightStickX = Input.GetAxis("Horizontal2");
		p1_rightStickY = Input.GetAxis("Vertical2");
		#endregion

		#region Set player 1 left stick movement to 0 if the controller value is inside the deadzone
		if (p1_leftStickX > 0 && p1_leftStickX < deadzone)
		{
			p1_leftStickX = 0;
		}

		if (p1_leftStickX < 0 && p1_leftStickX > -deadzone)
		{
			p1_leftStickX = 0;
		}

		if (p1_leftStickY > 0 && p1_leftStickY < deadzone)
		{
			p1_leftStickY = 0;
		}
		
		if (p1_leftStickY < 0 && p1_leftStickY > -deadzone)
		{
			p1_leftStickY = 0;
		}
		#endregion

		#region Set player 1 right stick movement to 0 if the controller value is inside the deadzone
		if (p1_rightStickX > 0 && p1_rightStickX < deadzone)
		{
			p1_rightStickX = 0;
		}
		
		if (p1_rightStickX < 0 && p1_rightStickX > -deadzone)
		{
			p1_rightStickX = 0;
		}
		
		if (p1_rightStickX > 0 && p1_rightStickX < deadzone)
		{
			p1_rightStickX = 0;
		}
		
		if (p1_rightStickX < 0 && p1_rightStickX > -deadzone)
		{
			p1_rightStickX = 0;
		}
		#endregion

		#region Get player 2 input
		p2_leftStickX = Input.GetAxis("Horizontal3");
		p2_leftStickY = Input.GetAxis("Vertical3");
		
		p2_rightStickX = Input.GetAxis("Horizontal4");
		p2_rightStickY = Input.GetAxis("Vertical4");
		#endregion
		
		#region Set player 2 left stick movement to 0 if the controller value is inside the deadzone
		if (p2_leftStickX > 0 && p2_leftStickX < deadzone)
		{
			p2_leftStickX = 0;
		}
		
		if (p2_leftStickX < 0 && p2_leftStickX > -deadzone)
		{
			p2_leftStickX = 0;
		}
		
		if (p2_leftStickY > 0 && p2_leftStickY < deadzone)
		{
			p2_leftStickY = 0;
		}
		
		if (p2_leftStickY < 0 && p2_leftStickY > -deadzone)
		{
			p2_leftStickY = 0;
		}
		#endregion

		#region Set player 2 right stick movement to 0 if the controller value is inside the deadzone
		if (p2_rightStickX > 0 && p2_rightStickX < deadzone)
		{
			p2_rightStickX = 0;
		}
		
		if (p2_rightStickX < 0 && p2_rightStickX > -deadzone)
		{
			p2_rightStickX = 0;
		}
		
		if (p2_rightStickY > 0 && p2_rightStickY < deadzone)
		{
			p2_rightStickY = 0;
		}
		
		if (p2_rightStickY < 0 && p2_rightStickY > -deadzone)
		{
			p2_rightStickY = 0;
		}
		#endregion
	}

	void GetButtonValues ()
	{
		#region Player 1 ABXY button inputs

		if (Input.GetButton("P1_AButton"))
		{
			p1_AButton = true;
		}

		else 
		{
			p1_AButton = false;
		}

		if (Input.GetButton("P1_BButton"))
		{
			p1_BButton = true;
		}
		
		else 
		{
			p1_BButton = false;
		}

		if (Input.GetButton("P1_XButton"))
		{
			p1_XButton = true;
		}
		
		else 
		{
			p1_XButton = false;
		}

		if (Input.GetButton("P1_YButton"))
		{
			p1_YButton = true;
		}

		else 
		{
			p1_YButton = false;
		}
		#endregion

		#region Player 2 ABXY button inputs

		if (Input.GetButton("P2_AButton"))
		{
			p2_AButton = true;
		}
		
		else 
		{
			p2_AButton = false;
		}
		
		if (Input.GetButton("P2_BButton"))
		{
			p2_BButton = true;
		}
		
		else 
		{
			p2_BButton = false;
		}
		
		if (Input.GetButton("P2_XButton"))
		{
			p2_XButton = true;
		}
		
		else 
		{
			p2_XButton = false;
		}

		if (Input.GetButton("P2_YButton"))
		{
			p2_YButton = true;
		}
		
		else 
		{
			p2_YButton = false;
		}
		#endregion

		#region Player 1 DPAD inputs

		if (Input.GetButton("P1_leftDpad"))
		{
			p1_leftDpad = true;
		}

		else
		{
			p1_leftDpad = false;
		}

		if (Input.GetButton("P1_rightDpad"))
		{
			p1_rightDpad = true;
		}
		
		else
		{
			p1_rightDpad = false;
		}

		if (Input.GetButton("P1_upDpad"))
		{
			p1_upDpad = true;
		}
		
		else
		{
			p1_upDpad = false;
		}

		if (Input.GetButton("P1_downDpad"))
		{
			p1_downDpad = true;
		}
		
		else
		{
			p1_downDpad = false;
		}

		#endregion

		#region Player 2 DPAD inputs

		if (Input.GetButton("P2_leftDpad"))
		{
			p2_leftDpad = true;
		}
		
		else
		{
			p2_leftDpad = false;
		}
		
		if (Input.GetButton("P2_rightDpad"))
		{
			p2_rightDpad = true;
		}
		
		else
		{
			p2_rightDpad = false;
		}
		
		if (Input.GetButton("P2_upDpad"))
		{
			p2_upDpad = true;
		}
		
		else
		{
			p2_upDpad = false;
		}
		
		if (Input.GetButton("P2_downDpad"))
		{
			p2_downDpad = true;
		}
		
		else
		{
			p2_downDpad = false;
		}

		#endregion

		#region Player 1 BUMPER inputs

		if (Input.GetButton("P1_leftBumper"))
		{
			p1_leftBumper = true;
		}
		
		else
		{
			p1_leftBumper = false;
		}

		if (Input.GetButton("P1_rightBumper"))
		{
			p1_rightBumper = true;
		}
		
		else
		{
			p1_rightBumper = false;
		}

		#endregion

		#region Player 2 BUMPER inputs

		if (Input.GetButton("P2_leftBumper"))
		{
			p2_leftBumper = true;
		}
		
		else
		{
			p2_leftBumper = false;
		}
		
		if (Input.GetButton("P2_rightBumper"))
		{
			p2_rightBumper = true;
		}
		
		else
		{
			p2_rightBumper = false;
		}

		#endregion
	}

	void GetTriggerValues()
	{
		#region Player 1 TRIGGER inputs

		p1_leftTrigger = Input.GetAxis("P1_leftTrigger");
		p1_rightTrigger = Input.GetAxis("P1_rightTrigger");

		#endregion

		#region Player 2 TRIGGER inputs
		
		p2_leftTrigger = Input.GetAxis("P2_leftTrigger");
		p2_rightTrigger = Input.GetAxis("P2_rightTrigger");
		
		#endregion
	}

}
