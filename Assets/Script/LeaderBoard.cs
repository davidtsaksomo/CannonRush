using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LeaderBoard : MonoBehaviour {
	public Text[] scoree;

	// Use this for initialization
	void Start () {
		int total = PlayerPrefs.GetInt ("highScoreYeahExpert", 0) + PlayerPrefs.GetInt ("highScoreYeah", 0) + PlayerPrefs.GetInt ("highScoreYeahAdvanced", 0);
		scoree[0].GetComponent<Text>().text = "Classic: " + PlayerPrefs.GetInt("highScoreYeah",0);
		scoree[1].GetComponent<Text>().text = "Advanced: " + PlayerPrefs.GetInt("highScoreYeahAdvanced",0);
		scoree[2].GetComponent<Text>().text = "Expert: " + PlayerPrefs.GetInt("highScoreYeahExpert",0);
		scoree[3].GetComponent<Text>().text = "Total: " + total;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
