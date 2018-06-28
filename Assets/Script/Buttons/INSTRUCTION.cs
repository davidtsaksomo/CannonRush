using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class INSTRUCTION : MonoBehaviour {
	public Color color;
	public GameObject uitext;
	// Use this for initialization
	void Start () {
	
	}
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

	// Update is called once per frame
	/*void Update () {
		if (Input.touchCount > 0) {
		if (guiTexture.HitTest (Input.GetTouch (0).position)) {
			if (Input.GetTouch (0).phase == TouchPhase.Began) {*/
	public void instr(){
		GetComponent<AudioSource>().Play ();
		Invoke("tutor", 0.1f);					
	}
	void tutor(){
				Application.LoadLevel ("Instruction1");
		}
		
			}
