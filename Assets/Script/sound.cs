using UnityEngine;
using System.Collections;

public class sound : MonoBehaviour {
	public GameObject[] button;
	void Awake() {
		if (PlayerPrefs.GetInt("SoundMute", 1) == 0) {
						button [1].SetActive (true);
			AudioListener.volume = 0;
				} else {
			button [0].SetActive (true);

				}
		}
	// Use this for initialization
	public void unmute () {
		AudioListener.volume = 2;
		button [1].SetActive (false);
		button [0].SetActive (true);
		PlayerPrefs.SetInt ("SoundMute", 1);
	}
	
	// Update is called once per frame
	public void mute () {
		AudioListener.volume = 0;
		button [0].SetActive (false);
		button [1].SetActive (true);
		PlayerPrefs.SetInt ("SoundMute", 0);
	}
}
