using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ObstacleMovementAdvanced : MonoBehaviour {
	public int speedObs;
	public int speedDes;
	public int direction;
	public int power;
	public int max;
	
	
	// Use this for initialization
	void Start () {
		transform.localScale = new Vector3(PlayerPrefs.GetFloat("meriamsize", 0.1f),PlayerPrefs.GetFloat("meriamsize", 0.1f),0);
		power = Random.Range (0, max);
		direction = Random.Range (0, 2);
		if (direction == 0){ GetComponent<Rigidbody2D>().gravityScale = 0.3f;}
		else {GetComponent<Rigidbody2D>().gravityScale = -0.3f;}
		if (power == 0) {
			GetComponent<Rigidbody2D> ().gravityScale = GetComponent<Rigidbody2D> ().gravityScale * 6;}
		if (power == 1) {
			GetComponent<Rigidbody2D> ().gravityScale = GetComponent<Rigidbody2D> ().gravityScale * 4;
		}
		if (power == 2) {
			GetComponent<Rigidbody2D> ().gravityScale = GetComponent<Rigidbody2D> ().gravityScale * 2;
		}

	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.right * speedObs * Time.deltaTime);
		Destroy (gameObject, speedDes * 1f);
	

		
	}
	void OnCollisionEnter2D(Collision2D coll) {
		
		if (coll.gameObject.name == "Cube") {
			
			
			Destroy (gameObject);

		} 
		if (coll.gameObject.name == "AboveCeiling") {
			GetComponent<Rigidbody2D>().gravityScale = -(GetComponent<Rigidbody2D>().gravityScale);
			

		} 
		if (coll.gameObject.name == "BelowCeiling") {
			
			
			GetComponent<Rigidbody2D>().gravityScale = -(GetComponent<Rigidbody2D>().gravityScale);
		} 
		if (coll.gameObject.name == "slider") {
			

			Destroy (GetComponent<CircleCollider2D>());
		} 
	}
	public void OnValueChanged(float a){
				transform.localScale = new Vector3 (a, a, a);

		}
}
