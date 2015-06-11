using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerMove : MonoBehaviour
{
	//here i am assigning a vector which contains the x and y and z co-ordinates of the mouse pos.
	Vector3 mousePos;
	Vector3 mPos;

	//I am fetching the health script
	Health healthScript;

	void Awake ()
	{
		// i am getting the health value from the health script
		healthScript = GetComponent <Health> ();
	}

	// Update is called once per frame
	void Update ()
	{

		mousePos = Input.mousePosition;
		
		mPos = Camera.main.ScreenToWorldPoint (mousePos);
		
		transform.position = new Vector3 (mPos.x, mPos.y, 4f);
	}

	//reset timer of oxygen when above cube2
	void OnTriggerEnter2D (Collider2D oxy)
	{
		if (oxy.tag == "cube2") {
			//resetBreath
			healthScript.resetbreath ();			
		}
	}
}
		


