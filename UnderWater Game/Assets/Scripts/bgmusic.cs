﻿using UnityEngine;
using System.Collections;

public class bgmusic : MonoBehaviour {
	public AudioClip bgSound;
	// Use this for initialization
	void Start () {
		GetComponent<AudioSource>().PlayOneShot (bgSound);
		DontDestroyOnLoad(this.gameObject);

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
