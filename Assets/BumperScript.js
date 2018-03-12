#pragma strict

public var BumpinScale = 0.1f;
public var scorekeeper:ScoreKeeping;
function Start () {

}

function Update () {

}

function OnCollisionEnter(ThethingIcollidedwith : Collision ){

if(ThethingIcollidedwith.collider.tag=="ball"){
scorekeeper.score++;
 transform.localScale += new Vector3(BumpinScale,BumpinScale,BumpinScale);


}
}

function OnCollisionExit(){

 transform.localScale -= new Vector3(BumpinScale,BumpinScale,BumpinScale);

}