using UnityEngine;
using System.Collections;

public class clickToShowMargin : MonoBehaviour {
    BannerAdds x;
	// Use this for initialization
	void Start(){
        x = (BannerAdds)GameObject.Find("BannerPrefab").GetComponent("BannerAdds");
	}
	void OnMouseDown(){
		x.setMargins (0.3f, 0.3f);
	}
}
