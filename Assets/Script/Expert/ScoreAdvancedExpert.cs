using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;

public class ScoreAdvancedExpert : MonoBehaviour {
	public int highScore;
	public int score;
	public GameObject cube;
	private bool isProcessing = false;
	void Awake(){
		
	}
	
	void Start(){
		score = cube.GetComponent<UpAndDownExpert> ().scoreanda;
		highScore = PlayerPrefs.GetInt("highScoreYeahExpert",0);

		
	}
	
	void Update(){
		
		
		if (score > highScore) {
			GetComponent<Text>().text = ("NEW HighScore: " + score);
			OnDisable();
		}
		if (highScore > score) {
			GetComponent<Text>().text = ("HighScore: " + highScore);
		}
		if (highScore == score) {
			GetComponent<Text>().text = ("HighScore: " + score);
		}
	}
	
	void OnDisable(){
		
		//If our scoree is greter than highscore, set new higscore and save.
		if(score>highScore){
			PlayerPrefs.SetInt("highScoreYeahExpert", score);
			PlayerPrefs.Save();
		}
	}


	
	//Share
	public void ShareIt(){
		if (!isProcessing)
			StartCoroutine (ShareScreenshot ());
	}
	public IEnumerator ShareScreenshot()
	{
		isProcessing = true;
		
		// wait for graphics to render
		yield return new WaitForEndOfFrame();
		
		//----------------------------------------------------------------------------------------------------------
		//------------------------------------------------------------------------- PHOTO
		// create the texture
		Texture2D screenTexture = new Texture2D(Screen.width, 
		                                        Screen.height,TextureFormat.RGB24,true);
		
		// put buffer into texture
		screenTexture.ReadPixels(new Rect(0f, 0f, Screen.width, Screen.height),0,0);
		
		// apply
		screenTexture.Apply();
		
		//----------------------------------------------------------------------------------------------------------
		//------------------------------------------------------------------------- PHOTO
		
		byte[] dataToSave = screenTexture.EncodeToPNG();
		
		string destination = Path.Combine
			(Application.persistentDataPath,System.DateTime.Now.ToString("yyyy-MM-dd-HHmmss") + ".png");
				#if !UNITY_WEBPLAYER
				//stuff that isn't supported in the web player
				File.WriteAllBytes(destination, dataToSave);
				#endif
		if(!Application.isEditor)
		{
			// block to open the file and share it ------------START
			AndroidJavaClass intentClass = new AndroidJavaClass("android.content.Intent");
			AndroidJavaObject intentObject = new AndroidJavaObject("android.content.Intent");
			intentObject.Call<AndroidJavaObject>("setAction", intentClass.GetStatic<string>
			                                     ("ACTION_SEND"));
			AndroidJavaClass uriClass = new AndroidJavaClass("android.net.Uri");
			AndroidJavaObject uriObject = uriClass.CallStatic<AndroidJavaObject>
				("parse","file://" + destination);
		//intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>
			//("EXTRA_TEXT"), "testo");
			//intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>
			//("EXTRA_SUBJECT"), "SUBJECT");
			intentObject.Call<AndroidJavaObject>("setType", "*/*");
			intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_SUBJECT"), "Cannon Rush");
			intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_TEXT"), ("Cannon Rush: My score is "+score + " on Expert level! Come play and beat my score if you can! Download now from SlideMe Market! http://slideme.org/application/cannon-rush"));
			intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>
			                                     ("EXTRA_STREAM"), uriObject);
			intentObject.Call<AndroidJavaObject>("setType", "text/plain");
			intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_SUBJECT"), "Cannon Rush");
			intentObject.Call<AndroidJavaObject>("putExtra", intentClass.GetStatic<string>("EXTRA_TEXT"), ("Cannon Rush: My score is "+score + " on Expert level! Come play and beat my score if you can! Download now from Download now from SlideMe Market! http://slideme.org/application/cannon-rush"));
			

			AndroidJavaClass unity = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
			AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject>
				("currentActivity");
			
			// option one:
			currentActivity.Call("startActivity", intentObject);
			
			// option two:
			//AndroidJavaObject jChooser = intentClass.CallStatic<AndroidJavaObject>
			//("createChooser", intentObject, "YO BRO! WANNA SHARE?");
			//currentActivity.Call("startActivity", jChooser);
			
			// block to open the file and share it ------------END
			
		}
		isProcessing = false;
		
	}
}