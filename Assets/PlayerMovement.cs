using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public InputHandler input;
	private float speed = 1; // this is the base speed of the player
	private float multiplier = 1; // this is the multiplier for the speed 

	// Use this for initialization
	void Start () {
		//dunno
	}
	
	// Update is called once per frame
	void Update () {
		// move horizontal
		transform.Translate(Vector3.left * input.moveX * speed * multiplier);
	}
}
