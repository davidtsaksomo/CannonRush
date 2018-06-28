using UnityEngine;
using System.Collections;

public class next1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	public void instruction1(){
		GetComponent<AudioSource>().Play();
		Invoke("tutor", 0.1f);		}
	void tutor(){					Application.LoadLevel ("Instruction2");
	}
}
