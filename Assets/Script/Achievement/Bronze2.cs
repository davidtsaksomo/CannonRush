using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Bronze2 : MonoBehaviour {
	public GameObject Condition;
	public Color color;
	public GameObject rectang;
	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetInt ("highScoreYeah", 0) > 200)
		{
			GetComponent<GUITexture> ().color = color;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
			if (GetComponent<GUITexture>().HitTest (Input.GetTouch (0).position)) {
				if (Input.GetTouch (0).phase == TouchPhase.Began) {
					Condition.GetComponent<Text>().text = "Get more than 200 points in Classic Mode";
					rectang.transform.position = Vector2.Lerp (rectang.transform.position, new Vector2(-1.933f, 1.93f), 1f);
				}
			}
		}
	}
}