#pragma strict

function Start () {

}

function Update () {
if(transform.position.y < -5){
Destroy(gameObject);

}
}