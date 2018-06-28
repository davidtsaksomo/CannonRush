using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SpawnObstacleAdvanced : MonoBehaviour {
	
	public Transform[] position;
	public GameObject bolameriam;
	public int spawnSpeed;
	public int i;
	public int j;
	public int k;
	public int h = 0;
	public int l;
	public int m;
	public int amount;
	public int limit = 3;
	public int nilai;
	public GameObject scores;
	public int gradual;
	public int speedObs;
	public GameObject sound;
	public int speedObss = 10;
	public bool limits;
	public GameObject[] cannon;
	protected Animator anim;
	public bool shoot1;
	public int max;
	public int min;
	public GameObject levels;
	int level;

	
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
		
		
		
		bolameriam.GetComponent<ObstacleMovementAdvanced> ().speedObs = speedObs;
		
		//limit and randomize the amount cannonball out per session 
		
		if (amount > limit) {
			
			amount = 0;
			
			limits = true;
			
			limit = Random.Range (2, 6);
		}
		
		//how the cannonball gradually increase in speed 

		if (nilai == 30) {
			speedObs = 7;
			spawnSpeed = 3;
			level = 2;
			levels.GetComponent<Text>().text = ("Level " + level);

		}
		if (nilai == 60) {
			level = 3;
				levels.GetComponent<Text>().text = ("Level " + level);
			speedObs = 6;
		
			
		}
		if (nilai == 100) {
			level = 4;
			levels.GetComponent<Text>().text = ("Level " + level);
		
			
			
		}



		//end
		
		
		
		
		
		
		
		
		
		scores.GetComponent<Text>().text = ("Score : " + nilai);
		
	}
	
	void TimeControl(){
		if (limits == false) {
			
			if (m == 5) { 
				k = Random.Range (0, 4);
				m = 0;
			}
			l = Random.Range (min, max);
			Invoke ("SpawningMeriam", 1.5f * l / spawnSpeed);
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
		//if (nilai < 31) {
		
		if (h == 0) {
			Instantiate (bolameriam, position [i].position, position [i].rotation);
			cannon [i].GetComponent<Animator> ().SetBool ("Shoot1", true);
			amount++;
			nilai++;
			sound.GetComponent<AudioSource>().Play();
		}
		if (h == 1) {
			Instantiate (bolameriam, position [j].position, position [j].rotation);
			cannon [j].GetComponent<Animator> ().SetBool ("Shoot1", true);
			amount++;
			nilai++;
			sound.GetComponent<AudioSource>().Play();
		}
		//}
		//after 111 points there's a probability of being double.
		

				/* if (nilai > 20) {
					
						if (h == 0) {
							Instantiate (bolameriam, position [j].position, position [j].rotation);
							cannon [i].GetComponent<Animator> ().SetBool ("Shoot1", true);
			
							}
						if (h == 1) {
							Instantiate (bolameriam, position [i].position, position [i].rotation);
							cannon [j].GetComponent<Animator> ().SetBool ("Shoot1", true);

							}
					
						}*/
				
		// end of ball positioning
		
		TimeControl ();
		
	}
	
}
