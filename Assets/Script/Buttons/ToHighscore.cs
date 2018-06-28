﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ToHighscore : MonoBehaviour {
	public Color color;
	public GameObject uitext;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
			if (GetComponent<GUITexture>().HitTest (Input.GetTouch (0).position)) {
				if (Input.GetTouch (0).phase == TouchPhase.Began) {
					GetComponent<AudioSource>().Play();
					Invoke("tutor", 0.1f);
					uitext.GetComponent<Text>().color = color;
				}
			}
		}
	}
	void tutor(){					Application.LoadLevel ("Highscore");
	}
}
