#pragma strict

// use this on particle effect prefabs when they need to be removed from the scene after playing

private var ps : ParticleSystem;

function Start(){
	ps = GetComponent(ParticleSystem);
}

function Update(){
	if(ps){
		if(!ps.IsAlive()){
			Destroy(gameObject);
		}
	}
}