using UnityEngine;
using System.Collections;

public class stop : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Destroy (GameObject.FindWithTag("bgmusic"));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
