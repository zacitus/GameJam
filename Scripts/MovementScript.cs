using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour {

	public GameObject playerObject ;
	private float upDownMovementInput = 0.0f;
	private float leftRightMovementInput = 0.0f;
	private float speed = 10.0f;
	private float screenY = 0;
	private float screenX = 0;
	// Use this for initialization
	void Start () {
		screenY = Screen.height;
		screenX = Screen.width;
	}
	
	// Update is called once per frame
	void Update () {
		leftRightMovementInput = Input.GetAxis ("Horizontal") * speed;
		upDownMovementInput = Input.GetAxis ("Vertical") * speed;

		if (playerObject.transform.position.y > -10) {
						Debug.Log (playerObject.transform.position.y);
						playerObject.transform.Translate (0, upDownMovementInput * Time.deltaTime, 0);
		}

		if (playerObject.transform.position.x > -(10) && playerObject.transform.position.x < (10)) {
			//Debug.Log (playerObject.transform.position.x);
			playerObject.transform.Translate (leftRightMovementInput * Time.deltaTime, 0, 0);
		}
	}
}
