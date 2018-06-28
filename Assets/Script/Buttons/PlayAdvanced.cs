using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayAdvanced : MonoBehaviour {
	public Color color;
	public GameObject uitext;
	public GameObject[] popup;
	public GameObject[] buttons;
	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetInt ("highScoreYeah", 0) < 50) {
						uitext.GetComponent<Text> ().color = Color.grey;
				}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
			if (GetComponent<GUITexture>().HitTest (Input.GetTouch (0).position)) {
				if (Input.GetTouch (0).phase == TouchPhase.Began) {
					if (PlayerPrefs.GetInt ("highScoreYeah", 0) > 49) {
						GetComponent<AudioSource>().Play();
						Invoke("tutor", 0.1f);
						uitext.GetComponent<Text>().color = color;
					}
					else{
						popup[0].SetActive (true);
						popup[1].SetActive (true);
						popup[2].SetActive (true);
					}


				}
			}
		}
	}
	public void exitYes(){
		Application.Quit ();
		print("ConnectionTesterStatus");
	}
	public void exitNo() {

		buttons[1].SetActive (true);
		buttons[2].SetActive (true);
		buttons[3].SetActive (true);
		buttons[4].SetActive (true);
		buttons[5].SetActive (true);
		buttons[6].SetActive (true);
		buttons[0].SetActive (true);
		Invoke ("destroy", 0.2f);

	}
	void destroy(){
				GameObject.FindGameObjectWithTag ("popup").SetActive (false);
				GameObject.FindGameObjectWithTag ("popup1").SetActive (false);
				GameObject.FindGameObjectWithTag ("popup2").SetActive (false);
				GameObject.FindGameObjectWithTag ("popup").SetActive (false);
		}
	void tutor(){					Application.LoadLevel ("scene3");
	}
}
