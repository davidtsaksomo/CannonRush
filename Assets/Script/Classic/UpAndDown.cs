using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using ChartboostSDK;
public class UpAndDown : MonoBehaviour {

	public int horSpeed;
	public int verSpeed;
	public Color color;
	public GameObject[] sounds;
	public GameObject[] endgame;
	public GameObject[] cannon;
	public GameObject[] achievements;
	public int scoreanda;
	public HighscoreTable highscoreTable;
	private float w;
	public bool Up;
	public bool Down;
	float posX;
	public GameObject explosionPrefab;
	public GameObject bgm;
	// Use this for initialization
	void OnEnable() {
		// Listen to all impression-related events
		Chartboost.didFailToLoadInterstitial += didFailToLoadInterstitial;
		Chartboost.didDismissInterstitial += didDismissInterstitial;
		Chartboost.didCloseInterstitial += didCloseInterstitial;
		Chartboost.didClickInterstitial += didClickInterstitial;
		Chartboost.didCacheInterstitial += didCacheInterstitial;
		Chartboost.shouldDisplayInterstitial += shouldDisplayInterstitial;
		Chartboost.didDisplayInterstitial += didDisplayInterstitial;
		Chartboost.didFailToLoadMoreApps += didFailToLoadMoreApps;
		Chartboost.didDismissMoreApps += didDismissMoreApps;
		Chartboost.didCloseMoreApps += didCloseMoreApps;
		Chartboost.didClickMoreApps += didClickMoreApps;
		Chartboost.didCacheMoreApps += didCacheMoreApps;
		Chartboost.shouldDisplayMoreApps += shouldDisplayMoreApps;
		Chartboost.didDisplayMoreApps += didDisplayMoreApps;
		Chartboost.didFailToRecordClick += didFailToRecordClick;
		Chartboost.didFailToLoadRewardedVideo += didFailToLoadRewardedVideo;
		Chartboost.didDismissRewardedVideo += didDismissRewardedVideo;
		Chartboost.didCloseRewardedVideo += didCloseRewardedVideo;
		Chartboost.didClickRewardedVideo += didClickRewardedVideo;
		Chartboost.didCacheRewardedVideo += didCacheRewardedVideo;
		Chartboost.shouldDisplayRewardedVideo += shouldDisplayRewardedVideo;
		Chartboost.didCompleteRewardedVideo += didCompleteRewardedVideo;
		Chartboost.didDisplayRewardedVideo += didDisplayRewardedVideo;
		Chartboost.didCacheInPlay += didCacheInPlay;
		Chartboost.didFailToLoadInPlay += didFailToLoadInPlay;
		Chartboost.didPauseClickForConfirmation += didPauseClickForConfirmation;
		Chartboost.willDisplayVideo += willDisplayVideo;
		#if UNITY_IPHONE
		Chartboost.didCompleteAppStoreSheetFlow += didCompleteAppStoreSheetFlow;
		#endif
	}
	/*REVMOB

	private static readonly Dictionary<String, String> REVMOB_APP_IDS = new Dictionary<String, String>() {
		{ "Android", " 54f92d07e02a65f53bcba328"}
	};
	private RevMob revmob;
	void Awake() {
		revmob = RevMob.Start(REVMOB_APP_IDS, "Cube");
	}

	*/


	void Start () {
		//CHARTBOOOSSTT CHACE
		Chartboost.cacheInterstitial(CBLocation.Default);





		//CHARTBOOST END
	
		w = Screen.width;
		
	}


			

	
	// Update is called once per frame
	void Update () {

				if (verSpeed == 12) {
						GetComponent<Animator> ().SetBool ("Up", true);
				}
				if (verSpeed == -12) {
						GetComponent<Animator> ().SetBool ("Up", false);
				}
						

				transform.Translate (Vector2.up * verSpeed * Time.deltaTime);
				transform.Translate (Vector2.right * horSpeed * Time.deltaTime * Input.GetAxis ("Horizontal"));

		posX = Mathf.Clamp (transform.position.x, -7.5f, 7.5f);
		transform.position = new Vector2 (posX, transform.position.y);
				// Does the touch happens on the right side of the screen?
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
	void OnCollisionEnter2D(Collision2D coll) {
				if (coll.gameObject.name == "AboveCeiling") {
						verSpeed = -12;
		
				}
				if (coll.gameObject.name == "BelowCeiling") {
					verSpeed = 12;
				}


		 if (coll.gameObject.name == "BolaMeriam(Clone)") {
			bgm.GetComponent<AudioSource>().Stop();
			scoreanda = GetComponent<SpawnObstacle> ().nilai;
			highscoreTable.AddScore(PlayerPrefs.GetString("PlayerName", "Jack"), scoreanda, "classic");
						sounds[0].GetComponent<AudioSource>().Play();
						verSpeed = 0;
						horSpeed = 0;
						Destroy (GetComponent<SpawnObstacle> ());
			Destroy (GetComponent<CircleCollider2D> ());
			Destroy (GetComponent<BoxCollider2D> ());
						Invoke ("death", 4f);
			GetComponent<SpriteRenderer>().color = color;

			cannon [0].GetComponent<Animator> ().SetBool ("Shoot1", false);
			cannon [1].GetComponent<Animator> ().SetBool ("Shoot1", false);
			cannon [2].GetComponent<Animator> ().SetBool ("Shoot1", false);
			cannon [3].GetComponent<Animator> ().SetBool ("Shoot1", false);
			cannon [4].GetComponent<Animator> ().SetBool ("Shoot1", false);
			cannon [5].GetComponent<Animator> ().SetBool ("Shoot1", false);
			cannon [6].GetComponent<Animator> ().SetBool ("Shoot1", false);
			cannon [7].GetComponent<Animator> ().SetBool ("Shoot1", false);

			Instantiate (explosionPrefab, transform.position, transform.rotation);
	
			           

				} 
		}
	public void death (){
		//REVMOB show
	
		//Chartboost show
		Chartboost.showInterstitial(CBLocation.Default);
		//achievemnet notifications
		if (!PlayerPrefs.HasKey ("advanced") && scoreanda> 49) {
			achievements[0].SetActive(true);
			achievements[5].GetComponent<Text>().text = "\nCongratulations!\n\nYou've Unlocked\n\nAdvanced Mode!";
			PlayerPrefs.SetInt("advanced",1);
		}
		if (!PlayerPrefs.HasKey ("bronze1") && scoreanda> 99) {
			achievements[0].SetActive(true);
			achievements[1].SetActive(true);
			PlayerPrefs.SetInt("bronze1",1);
				}
		if (!PlayerPrefs.HasKey ("bronze2") && scoreanda> 199) {
			achievements[0].SetActive(true);
			achievements[2].SetActive(true);
			PlayerPrefs.SetInt("bronze2",1);
			achievements[5].GetComponent<Text>().text = "Achievement Completed!\n\n\n\n\n\nGet more than 200 points";
		}
		if (!PlayerPrefs.HasKey ("sapphire1") && PlayerPrefs.GetInt ("highScoreYeahExpert", 0) + PlayerPrefs.GetInt ("highScoreYeah", 0) + PlayerPrefs.GetInt ("highScoreYeahAdvanced", 0)>299 ) {
			achievements[0].SetActive(true);
			achievements[3].SetActive(true);
			PlayerPrefs.SetInt("sapphire1",1);
			achievements[5].GetComponent<Text>().text = "Achievement Completed!\n\n\n\n\n\nGet more than total 300 points";
		}
		if (!PlayerPrefs.HasKey ("sapphire2") && PlayerPrefs.GetInt ("highScoreYeahExpert", 0) + PlayerPrefs.GetInt ("highScoreYeah", 0) + PlayerPrefs.GetInt ("highScoreYeahAdvanced", 0)>599 ) {
			achievements[0].SetActive(true);
			achievements[4].SetActive(true);
			PlayerPrefs.SetInt("sapphire2",1);
			achievements[5].GetComponent<Text>().text = "Achievement Completed!\n\n\n\n\n\nGet more than total 600 points";

		}






		//achievement notifications





	 	         endgame[0].SetActive(true);
				endgame[1].SetActive(true);
				endgame[2].SetActive(true);
				endgame[3].SetActive(false);
		endgame[4].SetActive(true);
		endgame[5].SetActive(true);
		endgame[6].SetActive(true);
		endgame[9].SetActive(true);
		endgame[10].SetActive(true);
		endgame[11].SetActive(false);
		if (scoreanda > 50){ endgame[8].SetActive(true);}
		else{endgame[7].SetActive(true);}



			// Show with default zone, pause engine and print result to debug log

		



		Destroy (GetComponent<SpriteRenderer> ());
		}





	void OnDisable() {
		// Remove event handlers
		Chartboost.didFailToLoadInterstitial -= didFailToLoadInterstitial;
		Chartboost.didDismissInterstitial -= didDismissInterstitial;
		Chartboost.didCloseInterstitial -= didCloseInterstitial;
		Chartboost.didClickInterstitial -= didClickInterstitial;
		Chartboost.didCacheInterstitial -= didCacheInterstitial;
		Chartboost.shouldDisplayInterstitial -= shouldDisplayInterstitial;
		Chartboost.didDisplayInterstitial -= didDisplayInterstitial;
		Chartboost.didFailToLoadMoreApps -= didFailToLoadMoreApps;
		Chartboost.didDismissMoreApps -= didDismissMoreApps;
		Chartboost.didCloseMoreApps -= didCloseMoreApps;
		Chartboost.didClickMoreApps -= didClickMoreApps;
		Chartboost.didCacheMoreApps -= didCacheMoreApps;
		Chartboost.shouldDisplayMoreApps -= shouldDisplayMoreApps;
		Chartboost.didDisplayMoreApps -= didDisplayMoreApps;
		Chartboost.didFailToRecordClick -= didFailToRecordClick;
		Chartboost.didFailToLoadRewardedVideo -= didFailToLoadRewardedVideo;
		Chartboost.didDismissRewardedVideo -= didDismissRewardedVideo;
		Chartboost.didCloseRewardedVideo -= didCloseRewardedVideo;
		Chartboost.didClickRewardedVideo -= didClickRewardedVideo;
		Chartboost.didCacheRewardedVideo -= didCacheRewardedVideo;
		Chartboost.shouldDisplayRewardedVideo -= shouldDisplayRewardedVideo;
		Chartboost.didCompleteRewardedVideo -= didCompleteRewardedVideo;
		Chartboost.didDisplayRewardedVideo -= didDisplayRewardedVideo;
		Chartboost.didCacheInPlay -= didCacheInPlay;
		Chartboost.didFailToLoadInPlay -= didFailToLoadInPlay;
		Chartboost.didPauseClickForConfirmation -= didPauseClickForConfirmation;
		Chartboost.willDisplayVideo -= willDisplayVideo;
		#if UNITY_IPHONE
		Chartboost.didCompleteAppStoreSheetFlow -= didCompleteAppStoreSheetFlow;
		#endif
	}
	//CHARTBOOST
	//CHARTBOOST
	//CHARTBOOST
	//CHARTBOOST

	void didFailToLoadInterstitial(CBLocation location, CBImpressionError error) {
		Debug.Log(string.Format("didFailToLoadInterstitial: {0} at location {1}", error, location));
	}
	
	void didDismissInterstitial(CBLocation location) {
		Debug.Log("didDismissInterstitial: " + location);
	}
	
	void didCloseInterstitial(CBLocation location) {
		Debug.Log("didCloseInterstitial: " + location);
	}
	
	void didClickInterstitial(CBLocation location) {
		Debug.Log("didClickInterstitial: " + location);
	}
	
	void didCacheInterstitial(CBLocation location) {
		Debug.Log("didCacheInterstitial: " + location);
	}
	
	bool shouldDisplayInterstitial(CBLocation location) {
		Debug.Log("shouldDisplayInterstitial: " + location);
		return true;
	}
	
	void didDisplayInterstitial(CBLocation location){
		Debug.Log("didDisplayInterstitial: " + location);
	}
	
	void didFailToLoadMoreApps(CBLocation location, CBImpressionError error) {
		Debug.Log(string.Format("didFailToLoadMoreApps: {0} at location: {1}", error, location));
	}
	
	void didDismissMoreApps(CBLocation location) {
		Debug.Log(string.Format("didDismissMoreApps at location: {0}", location));
	}
	
	void didCloseMoreApps(CBLocation location) {
		Debug.Log(string.Format("didCloseMoreApps at location: {0}", location));
	}
	
	void didClickMoreApps(CBLocation location) {
		Debug.Log(string.Format("didClickMoreApps at location: {0}", location));
	}
	
	void didCacheMoreApps(CBLocation location) {
		Debug.Log(string.Format("didCacheMoreApps at location: {0}", location));
	}
	
	bool shouldDisplayMoreApps(CBLocation location) {
		Debug.Log(string.Format("shouldDisplayMoreApps at location: {0}", location));
		return true;
	}
	
	void didDisplayMoreApps(CBLocation location){
		Debug.Log("didDisplayMoreApps: " + location);
	}
	
	void didFailToRecordClick(CBLocation location, CBImpressionError error) {
		Debug.Log(string.Format("didFailToRecordClick: {0} at location: {1}", error, location));
	}
	
	void didFailToLoadRewardedVideo(CBLocation location, CBImpressionError error) {
		Debug.Log(string.Format("didFailToLoadRewardedVideo: {0} at location {1}", error, location));
	}
	
	void didDismissRewardedVideo(CBLocation location) {
		Debug.Log("didDismissRewardedVideo: " + location);
	}
	
	void didCloseRewardedVideo(CBLocation location) {
		Debug.Log("didCloseRewardedVideo: " + location);
	}
	
	void didClickRewardedVideo(CBLocation location) {
		Debug.Log("didClickRewardedVideo: " + location);
	}
	
	void didCacheRewardedVideo(CBLocation location) {
		Debug.Log("didCacheRewardedVideo: " + location);
	}
	
	bool shouldDisplayRewardedVideo(CBLocation location) {
		Debug.Log("shouldDisplayRewardedVideo: " + location);
		return true;
	}
	
	void didCompleteRewardedVideo(CBLocation location, int reward) {
		Debug.Log(string.Format("didCompleteRewardedVideo: reward {0} at location {1}", reward, location));
	}
	
	void didDisplayRewardedVideo(CBLocation location){
		Debug.Log("didDisplayRewardedVideo: " + location);
	}
	
	void didCacheInPlay(CBLocation location) {
		Debug.Log("didCacheInPlay called: "+location);
	}
	
	void didFailToLoadInPlay(CBLocation location, CBImpressionError error) {
		Debug.Log(string.Format("didFailToLoadInPlay: {0} at location: {1}", error, location));
	}
	
	void didPauseClickForConfirmation() {
		Debug.Log("didPauseClickForConfirmation called");
	}
	
	void willDisplayVideo(CBLocation location) {
		Debug.Log("willDisplayVideo: " + location);
	}
	
	#if UNITY_IPHONE
	void didCompleteAppStoreSheetFlow() {
		Debug.Log("didCompleteAppStoreSheetFlow");
	}
	#endif
	//CHARTBOOST
	//CHARTBOOST//CHARTBOOST//CHARTBOOST
	//CHARTBOOST//CHARTBOOST
	//CHARTBOOST



}