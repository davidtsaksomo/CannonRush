using UnityEngine;
using System.Collections;

public class Back : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)){
			if (Application.loadedLevelName == ("Instruction")){
				Application.LoadLevel("Instruction1");
			}else if (Application.loadedLevelName == ("Instruction2")){
				Application.LoadLevel("Instruction");
			}
			else{
				Application.LoadLevel("Scene1");
			}
		}	
	}
}
