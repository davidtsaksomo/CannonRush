using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayExpert : MonoBehaviour {
	public Color color;
	public GameObject uitext;
	public GameObject[] popup;
	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetInt ("highScoreYeahAdvanced", 0) < 50) {
			uitext.GetComponent<Text> ().color = Color.grey;
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
			if (GetComponent<GUITexture>().HitTest (Input.GetTouch (0).position)) {
				if (Input.GetTouch (0).phase == TouchPhase.Began) {
					if (PlayerPrefs.GetInt ("highScoreYeahAdvanced", 0) > 49) {
						GetComponent<AudioSource>().Play();
						Invoke("tutor", 0.1f);
						uitext.GetComponent<Text>().color = color;
					}
					else{	popup[0].SetActive (true);
						popup[1].SetActive (true);
						popup[2].SetActive (true);}
				}
			}
		}
	}
	void tutor(){					Application.LoadLevel ("scene4");
	}
}
