using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	public void PlayGame(){
		SceneManager.LoadScene("Main");

	}
	public void PlayTankManiaGame(){
		SceneManager.LoadScene("TankMania");

	}
	public void PlayTankHoops(){
		SceneManager.LoadScene("save");

	}
	public void mainMenu(){
		SceneManager.LoadScene("MainMenu");

	}

	public void QuitGame (){

		Application.Quit();
	}
}