using UnityEngine;
using System.Collections;

public class BG : MonoBehaviour {
	public float speed;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("up", 1f, 4f );

		InvokeRepeating ("down", 3f,4f );

	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.up * speed * Time.deltaTime);
	}

	void up(){
				speed = 0.1f;

		}

	void down(){
				speed = -0.1f;
		}
}
