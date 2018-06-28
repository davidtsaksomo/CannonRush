using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreandaExpert : MonoBehaviour {
	public GameObject ube;
	int nilai;
	// Use this for initialization
	void Start () {
		nilai = ube.GetComponent<UpAndDownExpert> ().scoreanda;
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text>().text = ("Score: " + nilai);
	}
}