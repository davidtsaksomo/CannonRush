using UnityEngine;
using System.Collections;

public class Pseudoupanddown : MonoBehaviour {
	public int horSpeed;
	public int verSpeed;
	public GameObject[] sounds;
	private float w;
	public bool lefty;
	public GameObject explosionPrefab;
	// Use this for initialization
	void Start () {
		w = Screen.width;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.up * verSpeed * Time.deltaTime);
		transform.Translate (Vector2.right * horSpeed * Time.deltaTime * Input.GetAxis ("Horizontal"));

		if (lefty == true){
		if (Input.touchCount > 0) {
			if (Input.GetTouch (0).position.x > w / 2) {
				// Move your character right
				transform.Translate (Vector2.right * horSpeed * Time.deltaTime * 1);
				
				
				
			}
			
			// Does the touch happens on the left side of the screen?
			if (Input.GetTouch (0).position.x < w / 2) {
				// Move your character left
				
				transform.Translate (Vector2.right * horSpeed * Time.deltaTime * -1);
				
			}
			
			
			}
		}
	}
	void OnCollisionEnter2D(Collision2D coll) {
				if (coll.gameObject.name == "AboveCeiling") {
						verSpeed = -12;
			
				}
				if (coll.gameObject.name == "BelowCeiling") {
						verSpeed = 12;
				}

		if (coll.gameObject.name == "BolaMeriam(Clone)") {

			
			sounds[0].GetComponent<AudioSource>().Play();
			verSpeed = 0;
			horSpeed = 0;
			Destroy (GetComponent<PseudoSpawnObstacle> ());

			Invoke ("death", 4f);
			GetComponent<SpriteRenderer>().color = Color.red;
	
			Instantiate (explosionPrefab, transform.position, transform.rotation);
			
			
			
		} 
		}
	void death(){
				Application.LoadLevel (Application.loadedLevel);
		}
}
