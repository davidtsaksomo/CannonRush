using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Tutor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {

				if (Input.GetTouch (0).phase == TouchPhase.Began) {
					Application.LoadLevel ("scene2");
				GetComponent<Text>().text = "Loading...";
				}
			
		}
	}
}
