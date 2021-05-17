using UnityEngine;
using System.Collections;

public class clickToShowRules : MonoBehaviour {
    BannerAdds x;
	// Use this for initialization
	void Start(){
        x = (BannerAdds)GameObject.Find("BannerPrefab").GetComponent("BannerAdds");
	}
	void OnMouseDown(){
        BannerAdds.Rules[] rules = new BannerAdds.Rules[2];
        rules[0] = BannerAdds.Rules.ALIGN_PARENT_LEFT;
        rules[1] = BannerAdds.Rules.CENTER_VERTICAL;
		x.setRules (rules,2);
	}
}
