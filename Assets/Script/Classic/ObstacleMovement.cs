using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ObstacleMovement : MonoBehaviour {
	public int speedObs;
	public int speedDes;
	public GameObject explosionPrefab;


	// Use this for initialization
	void Start () {
		transform.localScale = new Vector3 (PlayerPrefs.GetFloat ("meriamsize", .1f), PlayerPrefs.GetFloat ("meriamsize", .1f), 0);
		Destroy (gameObject, speedDes * 1f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.right * speedObs * Time.smoothDeltaTime);
	

	
	}
	void OnCollisionEnter2D(Collision2D coll) {
	
		if (coll.gameObject.name == "Cube") {


			Destroy (gameObject);
		
			
			
			
		} 
	}
	public void OnValueChanged(float a){
		transform.localScale = new Vector3 (a, a, a);
		PlayerPrefs.SetFloat ("meriamsize", a);
	}
}
