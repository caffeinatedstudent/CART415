#pragma strict
public var score:int = 0;

function Start () {

}

function Update () {

 GetComponent.<UI.Text>().text = "Score: "+score;

}