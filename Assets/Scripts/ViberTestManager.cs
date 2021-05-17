using UnityEngine;
using System.Collections;

public class ViberTestManager : MonoBehaviour {
	public int id = 112;
	 Rect rect = new Rect();
    void OnGUI()
    {
        rect.x = 20;
        rect.y = 40;

        rect.width = Screen.width * 0.3f;
        rect.height = Screen.height * 0.1f;
		
		
	
		
    
		if (GUI.Button(rect, "Enable Viber"))   {
           vibertest.EnableViber(id);
        }

        rect.y = rect.y + rect.height+5;
        if (GUI.Button(rect, "Disable Viber")) {           
           vibertest.DisableViber();
        }
			
    
	 }



	// Use this for initialization
	void Start () {
     	vibertest.Instantiate();
	//vibertest.EnableViber();
	}
}
