using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PLAY : MonoBehaviour {
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
					uitext.GetComponent<Text>().color = color;
					GetComponent<AudioSource>().Play();
					Invoke("tutor", 0.1f);
				}
			}
		}
		}
	void tutor(){					Application.LoadLevel ("tutor");
	}
}
