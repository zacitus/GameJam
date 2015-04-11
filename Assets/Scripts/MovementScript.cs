using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour {

	public GameObject playerOneObject;
	public GameObject playerTwoObject;
	//private Rigidbody playerBody;
	private float upDownMovementInput = 0.0f;
	private float leftRightMovementInput = 0.0f;
	private float speed = 10.0f;

	// Import InputHandler.cs so we have deadzone accounted for
	public GetInput getInput;

	//private float screenY = 0.0f;
	//private float screenX = 0.0f;
	//private float movementLimitX = 8.0f;
	//private float movementLimitY = 2.0f;
	//private float movementLimitYOffset = 2.0f;

	// Use this for initialization
	void Start () {
		//get native screen height and width
		//screenY = Screen.height;
		//screenX = Screen.width;
		//calculate movement limits by screen area
		//movementLimitX = screenX / 100;
		//movementLimitY = screenY / 200;
		//movementLimitYOffset = screenY / 200;

		//gets the rigidbody used by the player object, used for AddForce, which is smoother, but requires different movement limits
		//playerBody = playerObject.GetComponent<Rigidbody>();

	}
	
	// FixedUpdate is called once per 0.2 seconds
	void FixedUpdate () {

		//stores input by predefined axis into -1 to 1 * speed
		if(playerOneObject){
			leftRightMovementInput = getInput.moveX * speed * Time.deltaTime;
			upDownMovementInput = getInput.moveY * speed * Time.deltaTime;

			playerOneObject.transform.Translate (leftRightMovementInput, upDownMovementInput, 0);
		}

		Vector3 direction = playerOneObject.transform.position - playerTwoObject.transform.position;
		float angle = Mathf.Atan2(direction.y,direction.x) * Mathf.Rad2Deg;
		
		playerOneObject.transform.rotation = Quaternion.Euler(0, 0, angle - 270);

		//if the player object is within the bounds the player can move, else the player is only allowed to move the one direction dictated by using positive or negative Mathf.Abs
		/*
		if (playerObject.transform.position.y > -movementLimitY-movementLimitYOffset && playerObject.transform.position.y < movementLimitY-movementLimitYOffset) {
			//Debug.Log (playerObject.transform.position.y);

			playerObject.transform.Translate (0, upDownMovementInput, 0);
			//playerBody.AddForce(0, upDownMovementInput, 0);
		}else if (playerObject.transform.position.y <= -movementLimitY-movementLimitYOffset){
			playerObject.transform.Translate (0, Mathf.Abs(upDownMovementInput), 0);
			//playerBody.AddForce(0, Mathf.Abs(upDownMovementInput), 0);
		}else if (playerObject.transform.position.y >= movementLimitY-movementLimitYOffset){
			playerObject.transform.Translate (0, -Mathf.Abs(upDownMovementInput), 0);
			//playerBody.AddForce(0, -Mathf.Abs(upDownMovementInput), 0);
		}

		if (playerObject.transform.position.x > -movementLimitX && playerObject.transform.position.x < movementLimitX) {
			//Debug.Log (playerObject.transform.position.x);

			playerObject.transform.Translate (leftRightMovementInput, 0, 0);
			//playerBody.AddForce(leftRightMovementInput, 0, 0);
		}else if (playerObject.transform.position.x <= -movementLimitX){
			playerObject.transform.Translate (Mathf.Abs(leftRightMovementInput), 0, 0);
			//playerBody.AddForce(Mathf.Abs(leftRightMovementInput), 0, 0);
		}else if (playerObject.transform.position.x >= movementLimitX){
			playerObject.transform.Translate (-Mathf.Abs(leftRightMovementInput), 0, 0);
			//playerBody.AddForce(-Mathf.Abs(leftRightMovementInput), 0, 0);
		}
		*/
	}
}
