using UnityEngine;
using System.Collections;

public class AimScript : MonoBehaviour {

	public GameObject playerTwoObject;
	private float upDownAimInput = 0.0f;
	private float leftRightAimInput = 0.0f;
	private float speed = 10.0f;

	public GetInput getinput;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//stores input by predefined axis into -1 to 1 * speed
		if(playerTwoObject){
			leftRightAimInput = getinput.p1_rightStickX * speed * Time.deltaTime;
			upDownAimInput = getinput.p1_rightStickY * speed * Time.deltaTime;
			
			playerTwoObject.transform.Translate (leftRightAimInput, upDownAimInput, 0);
		}
	}
}
