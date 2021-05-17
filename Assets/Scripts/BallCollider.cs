using UnityEngine;
using System.Collections;

public class BallCollider : MonoBehaviour {
	public static string displayText = "Score 0";
	public static string displayText1 = "Chances 15";
	public static int Score = 0;
	public static int gamePlayed = 0;
	public GUISkin mySkin = null;
	public GUISkin mySkin1 = null;
	public AudioClip catchSound;

	public TextMesh scoreText = null;

    

	Vector3 pointA ;
	Vector3 pointB ;
	// Use this for initialization
	void Start () {
		scoreText.text = "0";
		displayText = ""+Score+"";
		gamePlayed = PlayerPrefs.GetInt ("gameplayed", 0) + 1;
		PlayerPrefs.SetInt ("gameplayed", gamePlayed);
        vibertest.Instantiate();
	    
    }
	
	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter(Collision c)
	{
		if (c.gameObject.tag == "ball") {
			Score++;
            vibertest.EnableViber(31);
			audio.PlayOneShot (catchSound);
			int scor = PlayerPrefs.GetInt("score",0);
			if(Score>scor)
			{
				PlayerPrefs.SetInt("score",Score);
			}
			scoreText.text = "" + Score;
			//displayText = "Score "+Score+"";
			Destroy(c.gameObject);
            




		}
	}



	void OnGUI ()
	{
		//GUI.skin = mySkin;
		//	GUI.Label (new Rect (10, 40, 300,500),displayText);
		//GUI.skin = null;
		//GUI.skin = mySkin1;
		//	GUI.Label (new Rect ((Screen.width-300), 40, 300,500),displayText1);
		//GUI.skin = null;
	}
}
