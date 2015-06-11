using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Health : MonoBehaviour
{
	//here i am declaring the score and live variables
	public static int score;
	public static int lives;

	public Text scoreText;

	// the breath timer
	float startTime;
	//the max duration of the breath timer is of 10 seconds
	float maxDuration = 10f;
	float currentBreath;
	
	//this is the Gui skin variable for styling
	public GUISkin stylesheet;
	
//here i am stating the ammount of lives and score when the game is started
	void Start ()
	{

		if (Application.loadedLevel == 1) {
			lives = 3;
			score = 0;
		}
		//here i am starting the timer and keeping it updated throughout
		startTime = Time.time;
		currentBreath = maxDuration;
	}

	string ScoreLabel = "Score: ";
	string LivesLabel = "Lives: ";

	void OnGUI ()
	{
		// Assign the stylesheet to the text
		GUI.skin = stylesheet;
			

			//i am creating a  new label for the lives
		GUI.Label (new Rect (Screen.width - 120f, 20f, 80, 30), LivesLabel + lives);
			
		//28. Adding a quit button to go to main menu
		if (GUI.Button (new Rect (Screen.width / 2 - 80f, 25f, 200f, 25f), "QUIT")) {
			//35. if the saved score is less than the current score
			if (PlayerPrefs.GetInt ("score") < score) {
				//36. save the new high score
				PlayerPrefs.SetInt ("score", score);
			}
				
			// Load the menu scene (which is 0 in the BUILD SETTINGS)
			Application.LoadLevel (0);
		}
		//i am creating a new box and another box on top of it to display the current breath
		GUI.Box (new Rect (10, 50, 100, 20), "");
		GUI.Box (new Rect (10, 50, 100 * (currentBreath / maxDuration), 20), "");
	}
	
	
	
	// Update is called once per frame
	void Update ()
	{
		scoreText.text = ScoreLabel + score;
		//  i am making sure that the current breath when below 0 the game will end
		currentBreath = maxDuration - (Time.time - startTime);
		if (currentBreath <= 0f) {
			if (PlayerPrefs.GetInt ("score") < score) {
				//34. save the new high score
				PlayerPrefs.SetInt ("score", score);
			}
			// game over
			Application.LoadLevel (0);
		}

		// Reset score if lives are 0
		if (lives == 0) {
			//Game over, so i am saving the new score if it is greater than the currently stored highscore.
			if (PlayerPrefs.GetInt ("score") < score) {
				//32. save the new high score
				PlayerPrefs.SetInt ("score", score);
			}
			
			//Go back to main menu if you lose
			Application.LoadLevel (0);
			
			//reset game if you lose.  
			score = 0;
			lives = 3;
		}
		
		//Go back to menu if I press escape
		if (Input.GetKeyDown (KeyCode.Escape)) {
			

			if (PlayerPrefs.GetInt ("score") < score) {
				PlayerPrefs.SetInt ("score", score);
			}
			
			
			Application.LoadLevel (0);
		}
	}

	public void resetbreath ()
	{

		startTime = Time.time;

	}



}

		


