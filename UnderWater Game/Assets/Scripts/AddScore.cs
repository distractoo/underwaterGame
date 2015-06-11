using UnityEngine;
using System.Collections;

public class AddScore : MonoBehaviour {
	public AudioClip scoresound;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
	//When the Refuse items hit wiuth the scuba diver the score is stored
	void OnTriggerEnter2D (Collider2D coll)
	{
		if (coll.tag == "plus5") {
			//increase Health by 1
			GetComponent<AudioSource>().PlayOneShot (scoresound);
			Health.score+=5;
			Destroy (coll.gameObject);
		}
	}
}