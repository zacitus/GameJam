using UnityEngine;
using System.Collections;

public class ShootRocketScript : MonoBehaviour {

	private Vector3 firePosition;
	public GameObject rocket;
	private Vector3 playerOnePosition;
	public GameObject playerOneObject;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetButtonDown("Fire1") ||){
			firePosition = transform.position;
			playerOnePosition = playerOneObject.GetComponent<Transform>().position;
			Instantiate(rocket, playerOnePosition, playerOneObject.transform.rotation);
		}

	}
}
