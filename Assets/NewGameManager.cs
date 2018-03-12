using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewGameManager : MonoBehaviour {
int multiplier = 2;
int streak = 0;
	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt("Score",0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

void OnTriggerEnter (Collider hit){
 		
 if(hit.gameObject.tag == "ball")
 {
      
			AddScore ();
              
 }
}
void AddScore () {
 PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score")+100);
}
public void AddStreak(){
	streak++;
	if(streak>=24)
	multiplier = 4;
	else if(streak>=16)
	multiplier=3;
	else if(streak>=8)
	multiplier=1;
	else
	multiplier=1;
}
public void ResetStreak(){
	streak=0;
	multiplier=1;
	UpdateGUI();
}
void UpdateGUI(){
	PlayerPrefs.SetInt("Streak",streak);
	PlayerPrefs.SetInt("Mult",multiplier);
}
public int GetScore(){
	return 100*multiplier;
}
}
