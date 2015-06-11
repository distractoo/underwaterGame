using UnityEngine;
using System.Collections;

public class PowerControl : MonoBehaviour
{

	
	public int PowerSpeed;

	// Use this for initialization
	void Start ()
	{

	
	}
	
	// Update is called once per frame
	void Update ()
	{

		
		//Here i am rotating the object
		transform.Rotate (new Vector3 (0, 0, 10) * PowerSpeed * Time.deltaTime);
		
		///move the refuse along the y axis to the bottom
		if (transform.position.y > -5) {
			
			transform.Translate (new Vector3 (0, -1, 0) * PowerSpeed * Time.deltaTime, Space.World);
		}

	
	}
	void OnTriggerEnter2D (Collider2D col)
	{
		//if the refuse collides with cube 1 one live is deducted from the player, 
		if (col.tag == "cube") {
			Destroy (this.gameObject);
		}
	}
}
