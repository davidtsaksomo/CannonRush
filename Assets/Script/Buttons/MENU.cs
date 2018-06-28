using UnityEngine;
using System.Collections;

public class MENU : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per
	public void menu(){GetComponent<AudioSource>().Play ();
		Invoke ("menus", 0.1f);
		}
	void menus(){
				Application.LoadLevel ("scene1");
		}
}
