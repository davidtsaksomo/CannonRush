using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class Bronze1 : MonoBehaviour {
	public GameObject Condition;
	public GameObject rectang;
	public GameObject popup;
	public Color color;
	// Use this for initialization
	void Start () {
		if (!PlayerPrefs.HasKey ("completed") && PlayerPrefs.HasKey ("bronze1") && PlayerPrefs.HasKey ("bronze2") && PlayerPrefs.HasKey ("silver1") && PlayerPrefs.HasKey ("silver2") && PlayerPrefs.HasKey ("gold1") && PlayerPrefs.HasKey ("gold2") && PlayerPrefs.HasKey ("sapphire1") && PlayerPrefs.HasKey ("sapphire2")) {
						popup.SetActive (true);
			PlayerPrefs.SetInt("completed",1);
				}
				if (PlayerPrefs.GetInt ("highScoreYeah", 0) > 100)
		{
						GetComponent<GUITexture> ().color = color;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
			if (GetComponent<GUITexture>().HitTest (Input.GetTouch (0).position)) {
				if (Input.GetTouch (0).phase == TouchPhase.Began) {
					Condition.GetComponent<Text>().text = "Get more than 100 points in Classic Mode";
					rectang.transform.position = Vector2.Lerp (rectang.transform.position, new Vector2(-5.83f, 1.93f), 1f);
				}
			}
		}
	}
}
