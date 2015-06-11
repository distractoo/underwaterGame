using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timerlvl3 : MonoBehaviour
{
	public Text timeText;
	float currentTime;
	float startTime;
	public GUISkin stylesheet;
	string minutes;
	string seconds;
	
	void OnGUI ()
	{		
		
		minutes = (Mathf.Floor (currentTime / 60)).ToString ("00");
		seconds = (Mathf.Floor (currentTime % 60)).ToString ("00");
		
		GUI.skin = stylesheet;
	}
	
	void Start ()
	{
		//When i hit play start the timer
		startTime = Time.time;
		
		if (Application.loadedLevelName == "Level3") {
			
			startTime -= 40f;
		}
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		timeText.text = minutes + ":" + seconds;
		currentTime = Time.time - startTime;
		

		
	}
}
