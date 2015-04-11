using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour {

	public GameObject playerObject ;
	private Rigidbody playerBody;
	private float upDownMovementInput = 0.0f;
	private float leftRightMovementInput = 0.0f;
	private float speed = 1000.0f;
	private float screenY = 0.0f;
	private float screenX = 0.0f;
	private float movementLimitX = 6.0f;
	private float movementLimitY = 2.0f;
	private float movementLimitYOffset = 2.0f;

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
		leftRightMovementInput = Input.GetAxis ("Horizontal") * speed;
		upDownMovementInput = Input.GetAxis ("Vertical") * speed;

		//if the player object is within the bounds the player can move, else the player is only allowed to move the one direction dictated by using positive or negative Mathf.Abs
		if (playerObject.transform.position.y > -movementLimitY-movementLimitYOffset && playerObject.transform.position.y < movementLimitY-movementLimitYOffset) {
			//Debug.Log (playerObject.transform.position.y);
			playerObject.transform.Translate (0, upDownMovementInput * Time.deltaTime, 0);
			//playerBody.AddForce(0, upDownMovementInput * Time.deltaTime, 0);
		}else if (playerObject.transform.position.y <= -movementLimitY-movementLimitYOffset){
			playerObject.transform.Translate (0, Mathf.Abs(upDownMovementInput) * Time.deltaTime, 0);
			//playerBody.AddForce(0, Mathf.Abs(upDownMovementInput) * Time.deltaTime, 0);
		}else if (playerObject.transform.position.y >= movementLimitY-movementLimitYOffset){
			playerObject.transform.Translate (0, -Mathf.Abs(upDownMovementInput) * Time.deltaTime, 0);
			//playerBody.AddForce(0, -Mathf.Abs(upDownMovementInput) * Time.deltaTime, 0);
		}

		if (playerObject.transform.position.x > -movementLimitX && playerObject.transform.position.x < movementLimitX) {
			//Debug.Log (playerObject.transform.position.x);
			playerObject.transform.Translate (leftRightMovementInput * Time.deltaTime, 0, 0);
			//playerBody.AddForce(leftRightMovementInput * Time.deltaTime, 0, 0);
		}else if (playerObject.transform.position.x <= -movementLimitX){
			playerObject.transform.Translate (Mathf.Abs(leftRightMovementInput) * Time.deltaTime, 0, 0);
			//playerBody.AddForce(Mathf.Abs(leftRightMovementInput) * Time.deltaTime, 0, 0);
		}else if (playerObject.transform.position.x >= movementLimitX){
			playerObject.transform.Translate (-Mathf.Abs(leftRightMovementInput) * Time.deltaTime, 0, 0);
			//playerBody.AddForce(-Mathf.Abs(leftRightMovementInput) * Time.deltaTime, 0, 0);
		}
	}
}
