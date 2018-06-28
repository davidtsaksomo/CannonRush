using UnityEngine;
using System.Collections;

public class PseudoSpawnObstacle : MonoBehaviour {

	public Transform[] position;
	public GameObject bolameriam;
	public int spawnSpeed;
	public int i;
	public int j;
	public int k;
	public int h = 0;
	public int l;
	public GameObject sound;

	public int limit = 3;



	public int speedObs = 5;

	public bool limits;
	public GameObject[] cannon;
	protected Animator anim;

	public int max;
	
	// Use this for initialization
	void Start () {
		
		h = Random.Range (0, 2);
		limits = false;
		Invoke ("TimeControl", 0.5f);
		//cancel the animation.
		cannon [0].GetComponent<Animator> ().SetBool ("Shoot1", false);
		cannon [1].GetComponent<Animator> ().SetBool ("Shoot1", false);
		cannon [2].GetComponent<Animator> ().SetBool ("Shoot1", false);
		cannon [3].GetComponent<Animator> ().SetBool ("Shoot1", false);
		cannon [4].GetComponent<Animator> ().SetBool ("Shoot1", false);
		cannon [5].GetComponent<Animator> ().SetBool ("Shoot1", false);
		cannon [6].GetComponent<Animator> ().SetBool ("Shoot1", false);
		cannon [7].GetComponent<Animator> ().SetBool ("Shoot1", false);
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		bolameriam.GetComponent<ObstacleMovement> ().speedObs = speedObs;
	
		
		//how the cannonball gradually increase in speed

		
		//end
		
		
		
		
		
	
		
	}
	
	void TimeControl(){
		if (limits == false) {
		
			l = Random.Range (1, max);
			Invoke ("SpawningMeriam", 1f * l / spawnSpeed);
		} else {
			Start ();
		}
		
	}
	
	
	void SpawningMeriam (){
		i = Random.Range (0, 4);
		j = Random.Range (4, 8);
		
		
		//cancel the animation.
		cannon [0].GetComponent<Animator> ().SetBool ("Shoot1", false);
		cannon [1].GetComponent<Animator> ().SetBool ("Shoot1", false);
		cannon [2].GetComponent<Animator> ().SetBool ("Shoot1", false);
		cannon [3].GetComponent<Animator> ().SetBool ("Shoot1", false);
		cannon [4].GetComponent<Animator> ().SetBool ("Shoot1", false);
		cannon [5].GetComponent<Animator> ().SetBool ("Shoot1", false);
		cannon [6].GetComponent<Animator> ().SetBool ("Shoot1", false);
		cannon [7].GetComponent<Animator> ().SetBool ("Shoot1", false);
		
		
		//spawning and positioning cannonball
		
		
		// before 111 points theres no doubles
		//	if (nilai < 111) {
		
		if (h == 0) {
			Instantiate (bolameriam, position [i].position, position [i].rotation);
			cannon [i].GetComponent<Animator> ().SetBool ("Shoot1", true);
			sound.GetComponent<AudioSource>().Play();
		}
		if (h == 1) {
			Instantiate (bolameriam, position [j].position, position [j].rotation);
			cannon [j].GetComponent<Animator> ().SetBool ("Shoot1", true);
			sound.GetComponent<AudioSource>().Play();
		}
		//	}
		
		
		TimeControl ();
		
	}
	
	
	
}
