#pragma strict

public var BumpinScale = 0.1f;

function Start () {

}

function Update () {

}

function OnCollisionEnter(ThethingIcollidedwith : Collision ){

if(ThethingIcollidedwith.collider.tag=="ball"){

 transform.localScale += new Vector3(BumpinScale,BumpinScale,BumpinScale);


}
}

function OnCollisionExit(){

 transform.localScale -= new Vector3(BumpinScale,BumpinScale,BumpinScale);

}