using UnityEngine;
using System.Collections;

public class clickToShowMarginAndThenAlign : MonoBehaviour {
    BannerAdds x;
	// Use this for initialization
	void Start(){
        x = (BannerAdds)GameObject.Find("BannerPrefab").GetComponent("BannerAdds");
	}
	void OnMouseDown(){
		x.setMargins (0.1f, 0.0f);
        BannerAdds.Rules[] rules = new BannerAdds.Rules[1];
        rules[0] = BannerAdds.Rules.ALIGN_PARENT_BOTTOM;
		x.setRules (rules, 1);
	}
}
