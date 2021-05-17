using UnityEngine;
using System.Collections;

public class ScoreButtonClick : MonoBehaviour {

	
	public Texture2D NormalTexture;
	public Texture2D PressedTexture;

	public TextMesh GamePlayes;
	public TextMesh MaxScore;

    InterstitialAds x;
	// Use this for initialization
	void Start () {
		renderer.material.mainTexture = NormalTexture;
        x = (InterstitialAds)GameObject.Find("InterstitialPrefab").GetComponent("InterstitialAds");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseDown(){
		renderer.material.mainTexture = PressedTexture;
        x.showInterstitial();
	}
	
	void OnMouseUp(){
		
		renderer.material.mainTexture = NormalTexture;
		GameObject.FindGameObjectWithTag ("board").renderer.enabled = true;
		GameObject.FindGameObjectWithTag ("bg").renderer.enabled = true;
		GameObject.FindGameObjectWithTag ("backbt").renderer.enabled = true;
		GameObject.FindGameObjectWithTag ("gui3").renderer.enabled = true;
		GameObject.FindGameObjectWithTag ("gui4").renderer.enabled = true;
		GameObject.FindGameObjectWithTag ("gui5").renderer.enabled = true;
		GameObject.FindGameObjectWithTag ("bg").collider.enabled = true;
		GameObject.FindGameObjectWithTag ("board").collider.enabled = true;
		GameObject.FindGameObjectWithTag ("bg").collider.enabled = true;
		GameObject.FindGameObjectWithTag ("backbt").collider.enabled = true;

		GamePlayes.text = "Games Played : "+PlayerPrefs.GetInt("gameplayed",0);
		MaxScore.text = "Highest Score : "+PlayerPrefs.GetInt("score",0);
	}
}
