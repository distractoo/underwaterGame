using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timerlvl2 : MonoBehaviour
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
		
		if (Application.loadedLevelName == "Level2") {
			
			startTime -= 15f;
		}
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		timeText.text = minutes + ":" + seconds;
		currentTime = Time.time - startTime;
		
		
		//After 15 seconds, in level 1, go to level 2
		if (currentTime > 40 && Application.loadedLevelName == "Level2") {
			
			Application.LoadLevel ("Level3");
		}
		
	}
}
