#pragma strict

var cannonProjectile : GameObject;
var reloadTime : float = 1.0;
var turretTurnSpeed : float = 5.0;
var firePauseTime : float = 1.0;
var muzzleEffect : GameObject;
var muzzlePositions : Transform[];
var pivot_Tilt : Transform;
var pivot_Pan : Transform;
var aim_Pan : Transform;
var aim_Tilt : Transform;

private var turretTarget : Transform;
private var nextFireTime : float = 0.0;
private var nextMoveTime : float = 0.0;


function Update () {
	if(turretTarget){
		if(Time.time >= nextMoveTime){
			//aim_Pan.LookAt(turretTarget);
			//aim_Pan.eulerAngles = Vector3(0, aim_Pan.eulerAngles.y, 0);
			//aim_Tilt.LookAt(turretTarget);
		
			//pivot_Pan.rotation = Quaternion.Lerp(pivot_Pan.rotation, aim_Pan.rotation, Time.deltaTime * turretTurnSpeed);
			//pivot_Tilt.rotation = Quaternion.Lerp(pivot_Tilt.rotation, aim_Tilt.rotation, Time.deltaTime * turretTurnSpeed);
			
			pivot_Pan.LookAt(turretTarget);
			pivot_Tilt.LookAt(turretTarget);
			
			if(Time.time >= nextFireTime){
				FireProjectile();
			}
		}
		
	}else{
		pivot_Tilt.rotation = Quaternion.Lerp(pivot_Tilt.rotation, Quaternion.identity, Time.deltaTime * turretTurnSpeed);
	}
}

function OnTriggerStay(other : Collider){
	if(!turretTarget){
		if(other.gameObject.tag == "Ground_Enemy"){
			var r : float = Random.Range(0.25,firePauseTime);
			nextFireTime = Time.time + r;
			turretTarget = other.gameObject.transform;
		}
	}
}

function OnTriggerExit(other : Collider){
	if(other.gameObject.transform == turretTarget){
		turretTarget = null;
	}
}

function FireProjectile(){
	GetComponent.<AudioSource>().Play();
	nextFireTime = Time.time + reloadTime;
	nextMoveTime = Time.time + firePauseTime * 0.5;
	
	for(theMuzzlePos in muzzlePositions){
		var newMissle = Instantiate(cannonProjectile, theMuzzlePos.position, theMuzzlePos.rotation);
		newMissle.GetComponent(CannonProjectileScript).rocketTarget = turretTarget;
		Instantiate(muzzleEffect, theMuzzlePos.position, theMuzzlePos.rotation);
	}
}