#pragma strict
public var RightFlipperButton = false;
public var RightFlipperSecondButton = false;

function Start () {

}

function Update () {
	if(Input.GetKeyDown(KeyCode.RightShift)){
		GetComponent.<Animator>().SetBool("RightFlipperButton",true);
		GetComponent.<Animator>().SetBool("RightFlipperSecondButton",false);
	}
	if (Input.GetKeyUp(KeyCode.RightShift)){
		GetComponent.<Animator>().SetBool("RightFlipperSecondButton",true);
		GetComponent.<Animator>().SetBool("RightFlipperButton",false);

	}
}
