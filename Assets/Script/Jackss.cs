using UnityEngine;
using System.Collections;

public class Jackss : MonoBehaviour {
	public GameObject[] jack;
	public Transform[] jakss;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("jackwalk1", 0f, 29f);
		InvokeRepeating ("jackdown", 7f, 29f);
		InvokeRepeating ("jackup", 12f, 29f);
		InvokeRepeating ("jackwalk2", 19f, 29f);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void jackwalk1 (){

			Instantiate (jack[0], jakss [0].position, jakss[0].rotation);
	}
	void jackwalk2 (){Instantiate (jack[3], jakss [3].position, jakss[3].rotation);}
	void jackup(){Instantiate (jack[2], jakss [2].position, jakss[2].rotation);}
	void jackdown(){Instantiate (jack[1], jakss [1].position, jakss[1].rotation);}
}
