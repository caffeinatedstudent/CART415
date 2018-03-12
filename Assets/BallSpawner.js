#pragma strict

public var BallPrefab:Transform;

function Start () {

}

function Update () {
if(Input.GetKeyDown("space")){

Instantiate(BallPrefab.transform);
}
}