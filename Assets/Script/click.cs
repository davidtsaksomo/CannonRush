using UnityEngine;
using System.Collections;

public class click : MonoBehaviour {
	public GameObject[] des;
	public GameObject[] buttons;
	// Use this for initialization
	void OnEnable () {
		buttons[1].SetActive (false);
		buttons[2].SetActive (false);
		buttons[3].SetActive (false);
		buttons[4].SetActive (false);
		buttons[5].SetActive (false);
		buttons[6].SetActive (false);
		buttons[0].SetActive (false);
	}
	
	// Update is called once per frame
	public void OkClick () {

								des [0].SetActive (false);
								des [1].SetActive (false);
				des[2].SetActive(false);
								gameObject.SetActive (false);
				buttons[1].SetActive (true);
				buttons[2].SetActive (true);
				buttons[3].SetActive (true);
				buttons[4].SetActive (true);
				buttons[5].SetActive (true);
				buttons[6].SetActive (true);
				buttons[0].SetActive (true);


						}


}
