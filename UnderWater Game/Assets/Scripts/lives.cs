using UnityEngine;
using System.Collections;

public class lives : MonoBehaviour
{


	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		//if the refuse collides with cube 1 one live is deducted from the player, 
		if (col.tag == "cube") {
			//Reduce one live
			Health.lives--;			
			Destroy (this.gameObject);
		}
	}
}
