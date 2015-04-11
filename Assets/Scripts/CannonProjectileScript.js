#pragma strict

var rocketExplosion : GameObject;
var rocketSpeed : float = 3.0f;
var rocketDamage : float = 100.0;
var rocketTarget : Transform;

function Update () {
	transform.Translate(Vector3.forward * Time.deltaTime * rocketSpeed);
	if(rocketTarget){
		transform.LookAt(rocketTarget);
	}else{
		Destroy(gameObject);
	}
}

function OnTriggerEnter(other : Collider){
	if(other.gameObject.tag == "Player2"){
		//var m : int = Random.Range(0,10);
		//other.gameObject.SendMessage("TakeDamage", cannonDamage + m, SendMessageOptions.DontRequireReceiver);
		Explode();
	}
}

function Explode(){
	Instantiate(rocketExplosion, transform.position, Quaternion.identity);
	Destroy(gameObject);
}
