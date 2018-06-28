using UnityEngine;
using System.Collections;

public class HighscoreTable : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void AddScore(string name, int score, string level){
		int newScore = score;
		int oldScore;
		string newName = name;
		string oldName;

		for(int i=0;i<10;i++){
			if(PlayerPrefs.HasKey(i+"HScore"+level)){
				if(PlayerPrefs.GetInt(i+"HScore"+level)<newScore){ 
					// new score is higher than the stored score
					oldScore = PlayerPrefs.GetInt(i+"HScore"+level);
					oldName = PlayerPrefs.GetString(i+"HScoreName"+level);
					PlayerPrefs.SetInt(i+"HScore"+level,newScore);
					PlayerPrefs.SetString(i+"HScoreName"+level,newName);
		
					newScore = oldScore;
					newName = oldName;


				}
			}else{
				PlayerPrefs.SetInt(i+"HScore"+level,newScore);
				PlayerPrefs.SetString(i+"HScoreName"+level,newName);
				newScore = 0;
				newName = "Jack";
			
			}
		}
	}
}
