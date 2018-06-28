using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreandaAdvanced : MonoBehaviour {
	public GameObject ube;
	int nilai;
	// Use this for initialization
	void Start () {
		nilai = ube.GetComponent<UpAndDownAdvanced> ().scoreanda;
		
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Text>().text = ("Score: " + nilai);
	}
}