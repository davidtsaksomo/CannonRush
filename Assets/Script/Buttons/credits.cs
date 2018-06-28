using UnityEngine;
using System.Collections;

public class credits : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void credit(){
	Invoke("creditss", 0.1f);
		GetComponent<AudioSource>().Play ();}
	void creditss() {Application.LoadLevel("Credits");}
}