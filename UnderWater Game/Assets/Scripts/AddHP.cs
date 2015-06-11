using UnityEngine;
using System.Collections;

public class AddHP : MonoBehaviour {
	public AudioClip hpsound;

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
		if (coll.tag == "Hp") {
			//increase Health by 1
			GetComponent<AudioSource>().PlayOneShot (hpsound);
			Health.lives++;
			Destroy (coll.gameObject);
		}
	}
}