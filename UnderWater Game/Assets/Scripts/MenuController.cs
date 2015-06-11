using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour {
	
	//20. Add a reference to the style
	public GUISkin style;
	
	//39. Add another GUI 
	public GUISkin style2;
	
	//18. added GUI to menu controller
	void OnGUI()
	{
		//21. Add the skin to the gui
		GUI.skin = style;
		
		//19. Create a label with the name of the game in the middle of the screen
		GUI.Label (new Rect (Screen.width / 2-100f, Screen.height / 2-50f, 200f, 100f), "Asteroid Attack!");
		
		//25. Load the main game
		if (GUI.Button (new Rect (Screen.width / 2 - 100f, Screen.height / 2 + 30f, 200f, 50f), "PLAY")) {
			//26. Load the main scene (which is 1 in the BUILD SETTINGS)
			Application.LoadLevel (1);
		}
		
		//40. Set the yellow style for the high scores
		GUI.skin = style2;
		//38. Add a label showing the high score
		GUI.Label (new Rect (Screen.width / 2-100f, Screen.height / 2+60f, 200f, 100f), "High score: "+PlayerPrefs.GetInt("score"));
	}
	
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
