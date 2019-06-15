#pragma strict
var target : GameObject;
var adjust : float;

function Start () {

}

function Update () {

}

function OnTriggerEnter2D (other : Collider2D){
	if(other.gameObject.name == "Player"){

		other.transform.position = Vector3(target.transform.position.x, target.transform.position.y + adjust,0);
		}
}