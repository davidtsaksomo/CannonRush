using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ObstacleMovementExpert : MonoBehaviour {
	public int speedObs;
	public int speedObsVer = 0;
	public int speedDes;
	public int direction;
	public int power;
	public int max;
	public int type;
	
	
	// Use this for initialization
	void Start () {
		//transform.localScale = new Vector3(PlayerPrefs.GetFloat("meriamsize", 0.1f),PlayerPrefs.GetFloat("meriamsize", 0.1f),0);
		type = Random.Range (0, 2);
		power = Random.Range (0, max);
		direction = Random.Range (0, 2);
		//diagonal type
		if (type == 0) { 
						if (direction == 0) {
								speedObsVer = 1;
						} else {
								speedObsVer = -1;
						}
						if (power == 0) {
								speedObsVer = speedObsVer * 2;
						}
						if (power == 1) {
								speedObsVer = speedObsVer * 4;
						}
						if (power == 2) {
								speedObsVer = speedObsVer * 3;
						}
				}

		//gravity type
		if (type == 1) {
			if (direction == 0){ GetComponent<Rigidbody2D>().gravityScale = 0.3f;}
			else {GetComponent<Rigidbody2D>().gravityScale = -0.3f;}
			if (power == 0) {
				GetComponent<Rigidbody2D> ().gravityScale = GetComponent<Rigidbody2D> ().gravityScale * 3;
			}
			if (power == 1) {
				GetComponent<Rigidbody2D> ().gravityScale = GetComponent<Rigidbody2D> ().gravityScale * 4;
			}
			if (power == 2) {
				GetComponent<Rigidbody2D> ().gravityScale = GetComponent<Rigidbody2D> ().gravityScale * 2;
			}
				}
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.right * speedObs * Time.deltaTime);
		transform.Translate (Vector2.up * speedObsVer * Time.deltaTime);
		Destroy (gameObject, speedDes * 1f);
	

		
	}
	void OnCollisionEnter2D(Collision2D coll) {
		
		if (coll.gameObject.name == "Cube") {
			
			
			Destroy (gameObject);

		} 
		if (coll.gameObject.name == "AboveCeiling") {
			speedObsVer = -speedObsVer ;
			GetComponent<Rigidbody2D>().gravityScale = -(GetComponent<Rigidbody2D>().gravityScale);

		} 
		if (coll.gameObject.name == "BelowCeiling") {
			
			GetComponent<Rigidbody2D>().gravityScale = -(GetComponent<Rigidbody2D>().gravityScale);	
		speedObsVer = -speedObsVer;
		}
		 

	}
	public void OnValueChanged(float a){
		transform.localScale = new Vector3 (a, a, a);

	}
}
