using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayVideo : MonoBehaviour {

	public MovieTexture movie;
	public float waitTime = 5f;
	private float timer = 0;
	public string mainMenu;
	void Start () {
		GetComponent<RawImage>().texture = movie as MovieTexture;
		movie.Play();	
		Time.timeScale = 1f;
		Cursor.visible = true;
	}
	void Update()
	{
		timer += Time.deltaTime;
		
		if (timer >= waitTime)
			Application.LoadLevel(mainMenu);
	}
	
}