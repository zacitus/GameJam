using UnityEngine;
using System.Collections;

public class RocketScript : MonoBehaviour {

	private GameObject playerTwoObject;
	private Rigidbody2D rb;
	public GameObject rocketExplosion;
	private float rocketSpeed = 3.0f;
	private float rocketDamage = 100.0f;
	public Transform rocketTarget;

	// Use this for initialization
	void Start () {
		playerTwoObject = GameObject.FindGameObjectWithTag("Player2");
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(playerTwoObject.transform.position);
		transform.Translate(Vector3.forward * Time.deltaTime * rocketSpeed);

		if(transform.position == playerTwoObject.transform.position){
			Destroy(gameObject);
		}
	}

	void OnTriggerEnter(Collider other){
		Destroy(gameObject);
	}
}
