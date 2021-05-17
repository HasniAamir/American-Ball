using UnityEngine;
using System.Collections;

public class clicktoloadinterstitial : MonoBehaviour {
    InterstitialAds x;
	// Use this for initialization
	void Start () {
        x = (InterstitialAds)GameObject.Find("InterstitialPrefab").GetComponent("InterstitialAds");
	}
	
	// Update is called once per frame
	void OnMouseDown(){
		x.showInterstitial ();
	}
}
