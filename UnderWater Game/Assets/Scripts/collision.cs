using UnityEngine;
using System.Collections;

public class collision : MonoBehaviour
{
	public AudioClip pickupSound;
	

	
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{

	}
	
	//When the Refuse items hit wiuth the scuba diver the score is stored
	void OnTriggerEnter2D (Collider2D otherObject)
	{
		if (otherObject.tag == "refuse") {
			//increase the score by 1
			GetComponent<AudioSource>().PlayOneShot (pickupSound);
			Health.score++;
			Destroy (otherObject.gameObject);
		}
	}

}


