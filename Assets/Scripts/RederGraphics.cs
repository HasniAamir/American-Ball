using UnityEngine;
using System.Collections;

public class RederGraphics : MonoBehaviour {
    InterstitialAds x;
	// Use this for initialization
	void Start () {
		GameObject.FindGameObjectWithTag ("board").renderer.enabled = false;

		GameObject.FindGameObjectWithTag ("backbt").renderer.enabled = false;
		GameObject.FindGameObjectWithTag ("gui3").renderer.enabled = false;
		GameObject.FindGameObjectWithTag ("gui4").renderer.enabled = false;
		GameObject.FindGameObjectWithTag ("gui5").renderer.enabled = false;
		GameObject.FindGameObjectWithTag ("loading").renderer.enabled = false;

		GameObject.FindGameObjectWithTag ("board").collider.enabled = false;
		GameObject.FindGameObjectWithTag ("bg").collider.enabled = false;
		GameObject.FindGameObjectWithTag ("backbt").collider.enabled = false;
	

		GameObject.FindGameObjectWithTag ("closemenu").renderer.enabled = false;
		GameObject.FindGameObjectWithTag ("closemenu").collider.enabled = false;
		GameObject.FindGameObjectWithTag ("bg").renderer.enabled = false;
		GameObject.FindGameObjectWithTag ("no").renderer.enabled = false;
		GameObject.FindGameObjectWithTag ("yes").renderer.enabled = false;
		GameObject.FindGameObjectWithTag ("no").collider.enabled = false;
		GameObject.FindGameObjectWithTag ("yes").collider.enabled = false;

        x = (InterstitialAds)GameObject.Find("InterstitialPrefab").GetComponent("InterstitialAds");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
            x.showInterstitial();
			GameObject.FindGameObjectWithTag ("backbt").renderer.enabled = false;
			GameObject.FindGameObjectWithTag ("gui3").renderer.enabled = false;
			GameObject.FindGameObjectWithTag ("gui4").renderer.enabled = false;
			GameObject.FindGameObjectWithTag ("gui5").renderer.enabled = false;
			GameObject.FindGameObjectWithTag ("board").renderer.enabled = false;
			GameObject.FindGameObjectWithTag ("board").collider.enabled = false;

			GameObject.FindGameObjectWithTag ("backbt").collider.enabled = false;

			GameObject.FindGameObjectWithTag ("closemenu").renderer.enabled = true;
			GameObject.FindGameObjectWithTag ("yes").renderer.enabled = true;
			GameObject.FindGameObjectWithTag ("no").renderer.enabled = true;
			GameObject.FindGameObjectWithTag ("yes").collider.enabled = true;
			GameObject.FindGameObjectWithTag ("no").collider.enabled = true;
			GameObject.FindGameObjectWithTag ("bg").renderer.enabled = true;
			GameObject.FindGameObjectWithTag ("bg").collider.enabled = true;
			GameObject.FindGameObjectWithTag ("closemenu").collider.enabled = true;
			MoveObject.GuiOn = true;
			Time.timeScale = 0;
			
		}
	}
}
