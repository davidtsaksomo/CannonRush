using UnityEngine;
using System.Collections;

public class Busmovement : MonoBehaviour {
	public int speedObs;
	public int speedDes;
	public Vector2 newposition;

	// Use this for initialization
	void Start () {
				newposition = new Vector2 (0.5f, transform.position.y);

		}
	
	// Update is called once per frame
	void Update () {

		transform.position = Vector2.MoveTowards (transform.position, newposition, speedObs * 1f * Time.deltaTime);
		}	

}
