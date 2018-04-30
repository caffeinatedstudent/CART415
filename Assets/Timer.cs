using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace Complete
{
public class Timer : MonoBehaviour
{
	public int timeLeft = 5;
	public Text countdownText;
	 public GameObject target;
	 public GameObject disabled;
GameObject gmo;
	// Use this for initialization
	void Start()
	{
		target.SetActive(false);
		StartCoroutine("LoseTime");
		         
				  gmo = GameObject.Find("Tank");

	}

	// Update is called once per frame
	void Update()
	{
		countdownText.text = ("Time Left = " + timeLeft);

		if (timeLeft <= 0)
		{
			StopCoroutine("LoseTime");
			countdownText.text = "Times Up!";
			Reset();
		}
	}

	IEnumerator LoseTime()
	{
		while (true)
		{
			yield return new WaitForSeconds(1);
			timeLeft--;
		}
	}


	void Reset (){
		
target.SetActive(true);

gmo.GetComponent<TankMovement>().enabled = false;
	gmo.GetComponent<TankShooting>().enabled = false;

	}
}



}