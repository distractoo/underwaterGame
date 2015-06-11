using UnityEngine;
using System.Collections;

public class MenuController1 : MonoBehaviour
{

	public GUISkin style;
	public GUISkin style2;

	void OnGUI ()
	{
		GUI.skin = style;
		
			
		//Loading the main game
		if (GUI.Button (new Rect (Screen.width / 2 - 50f, Screen.height / 2 + 30f, 200f, 50f), "PLAY")) {
			//load level 1 
			Application.LoadLevel (1);
		}
		
		//Style Number 2 for high Score
		GUI.skin = style2;

		GUI.Label (new Rect (Screen.width / 2 - 50f, Screen.height / 2 + 60f, 200f, 100f), "High score: " + PlayerPrefs.GetInt ("score"));
	}
	
	
	
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
