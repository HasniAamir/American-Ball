using UnityEngine;
using System.Collections;

public class vibertest : MonoBehaviour {

	

    static AndroidJavaClass viberPluginClass;
    static AndroidJavaClass unityPlayer;
    static AndroidJavaObject currActivity;

  
    public static void Instantiate()
    {
        Debug.Log("Instantiate Called");
        viberPluginClass = new AndroidJavaClass("org.purepush.vibertest.MainActivity");
        unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        currActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
         viberPluginClass.CallStatic("initViber",currActivity);
        Debug.Log("Instantiate FINISHED");
    }

  
    public static void EnableViber(int id)
    {
        Debug.Log("ENABLED Called");
        viberPluginClass.CallStatic("startViber",currActivity,id);
		Debug.Log("ENABLED FINISHED");        
    }


  
    public static void DisableViber()
    {
        Debug.Log("DISABLED Called");
		viberPluginClass.CallStatic("stopViber",currActivity);
        Debug.Log("DISABLED FINISHED");
    }

}
