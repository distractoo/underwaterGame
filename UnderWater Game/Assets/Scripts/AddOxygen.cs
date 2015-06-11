using UnityEngine;
using System.Collections;

public class AddOxygen : MonoBehaviour {
	Health healthScript;
	public AudioClip oxysound;

	void Awake ()
	{
		// i am getting the health value from the health script
		healthScript = GetComponent <Health> ();
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D oxy)
	{
		if (oxy.tag == "oxy5") {
			//resetBreath
			GetComponent<AudioSource>().PlayOneShot (oxysound);
			healthScript.resetbreath ();
			Destroy (oxy.gameObject);
		}
	}
}
