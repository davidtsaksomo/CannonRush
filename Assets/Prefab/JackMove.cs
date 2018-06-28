using UnityEngine;
using System.Collections;

public class JackMove : MonoBehaviour {
	public int verSpeed;
	public int horSpeed;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, 5f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.up * verSpeed * Time.deltaTime);
		transform.Translate (Vector2.right * horSpeed * Time.deltaTime);
	}
}
