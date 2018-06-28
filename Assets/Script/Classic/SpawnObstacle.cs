using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SpawnObstacle : MonoBehaviour {

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
	public GameObject[] scores;
	public int gradual;
	public int speedObs = 5;
	public GameObject sound;
	public int speedObss = 10;
	public bool limits;
	public GameObject[] cannon;
	protected Animator anim;
	public bool shoot1;
	public int max;
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


		bolameriam.GetComponent<ObstacleMovement> ().speedObs = speedObs;

		//limit and randomize the amount cannonball out per session 

				if (amount > limit) {
		
						amount = 0;
					
			            limits = true;

						limit = Random.Range (2, 6);
				}

		//how the cannonball gradually increase in speed
		if (nilai > 10) {
			spawnSpeed = 5;
						if (nilai > 20) {
								speedObs = 4;
								spawnSpeed = 4;
								level = 2;
								scores [1].GetComponent<Text> ().text = ("Level " + level);
								if (nilai > 40) {
										speedObs = 5;
										max = 3;
										spawnSpeed = 3;
										level = 3;
										scores [1].GetComponent<Text> ().text = ("Level " + level);
										if (nilai > 70) {
												speedObs = 4;
												level = 4;
												scores [1].GetComponent<Text> ().text = ("Level " + level);
												if (nilai > 90) {
														speedObs = 6;
														level = 5;
														scores [1].GetComponent<Text> ().text = ("Level " + level);
														if (nilai > 100) {
																speedObs = 7;
																level = 6;
																scores [1].GetComponent<Text> ().text = ("Level " + level);
														}
														if (nilai > 130) {
																speedObs = 8;
																level = 7;
																scores [1].GetComponent<Text> ().text = ("Level " + level);
							
														}
														if (nilai > 170) {
																speedObs = 9;
																level = 8;
																scores [1].GetComponent<Text> ().text = ("Level " + level);
							
														}
														if (nilai > 200) {
																speedObs = 10;
																spawnSpeed = 3;
																level = 9;
																scores [1].GetComponent<Text> ().text = ("Level " + level);
														}

												}
										}
								}
						}
				}


		//end






		


		scores[0].GetComponent<Text>().text = ("Score : " + nilai);

	
	}

	void TimeControl(){
		if (limits == false) {
			
			if (m == 5) { 
				k = Random.Range (0, 4);
				m = 0;
			}
						l = Random.Range (1, max);
						Invoke ("SpawningMeriam", spawnSpeed/2f );
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
			//	}


		TimeControl ();

		}


	
}
