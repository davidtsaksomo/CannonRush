using UnityEngine;
using System.Collections;

public class QUIT : MonoBehaviour {
	public Color color;
	public GameObject[] popup;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
			if (GetComponent<GUITexture>().HitTest (Input.GetTouch (0).position)) {
				if (Input.GetTouch (0).phase == TouchPhase.Began) {
					GetComponent<AudioSource>().Play();
					popup[0].SetActive (true);
					popup[1].SetActive (true);
					popup[2].SetActive (true);
					popup[3].SetActive (true);
					GameObject.FindGameObjectWithTag ("buttons").SetActive (false);
					GameObject.FindGameObjectWithTag ("buttons").SetActive (false);
					GameObject.FindGameObjectWithTag ("buttons").SetActive (false);
					GameObject.FindGameObjectWithTag ("buttons").SetActive (false);
					GameObject.FindGameObjectWithTag ("buttons").SetActive (false);
					GameObject.FindGameObjectWithTag ("buttons").SetActive (false);
					GameObject.FindGameObjectWithTag ("buttons").SetActive (false);
				}
			}
		}
}
}