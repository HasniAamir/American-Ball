using UnityEngine;
using System.Collections;

public class clickToHideBanner : MonoBehaviour {
    BannerAdds x;
	// Use this for initialization
	void Start(){
        x = (BannerAdds)GameObject.Find("BannerPrefab").GetComponent("BannerAdds");
	}
	void OnMouseDown(){
		x.hideBanner ();
	}
}
