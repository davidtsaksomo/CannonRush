﻿using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

}
public void restart(){
		GetComponent<AudioSource>().Play ();
		Invoke ("restartts", 0.1f);
		}
	void restartts(){				Application.LoadLevel (Application.loadedLevel);
	}
}