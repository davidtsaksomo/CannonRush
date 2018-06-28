using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Standings : MonoBehaviour {
	public string level;
	public string myString;
	// Use this for initialization
	void Start () {
		GetComponent<Text>().text =myString+"\n1. "+PlayerPrefs.GetString("0HScoreName"+level, "Jack")+": "+PlayerPrefs.GetInt("0HScore"+level)+"\n"+
			"2. "+PlayerPrefs.GetString("1HScoreName"+level, "Jack")+": "+PlayerPrefs.GetInt("1HScore"+level)+"\n"+
				"3. "+PlayerPrefs.GetString("2HScoreName"+level, "Jack")+": "+PlayerPrefs.GetInt("2HScore"+level)+"\n"+
				"4. "+PlayerPrefs.GetString("3HScoreName"+level, "Jack")+": "+PlayerPrefs.GetInt("3HScore"+level)+"\n"+
				"5. "+PlayerPrefs.GetString("4HScoreName"+level, "Jack")+": "+PlayerPrefs.GetInt("4HScore"+level)+"\n"+
				"6. "+PlayerPrefs.GetString("5HScoreName"+level, "Jack")+": "+PlayerPrefs.GetInt("5HScore"+level)+"\n"+
				"7. "+PlayerPrefs.GetString("6HScoreName"+level, "Jack")+": "+PlayerPrefs.GetInt("6HScore"+level)+"\n"+
				"8. "+PlayerPrefs.GetString("7HScoreName"+level, "Jack")+": "+PlayerPrefs.GetInt("7HScore"+level)+"\n"+
				"9. "+PlayerPrefs.GetString("8HScoreName"+level, "Jack")+": "+PlayerPrefs.GetInt("8HScore"+level)+"\n"+
				"10. "+PlayerPrefs.GetString("9HScoreName"+level, "Jack")+": "+PlayerPrefs.GetInt("9HScore"+level)
				; 
	}
	
	// Update is called once per frame
	void Update () {

	}
}
