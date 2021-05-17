using UnityEngine;
using System.Collections;

public class clickToShowBanner : MonoBehaviour {
    BannerAdds x;
	// Use this for initialization
	void Start(){
        x = (BannerAdds)GameObject.Find("BannerPrefab").GetComponent("BannerAdds");
	}
	void OnMouseDown(){
		x.showBanner ();
		guiText.text = 0.3 * Screen.width + " " + 0.3 * Screen.height;
	}
}
