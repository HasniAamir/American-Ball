using UnityEngine;
using System.Collections;

public class RunSpeed : MonoBehaviour {
	public float runspeed = 0.0f;
	private Vector3 position;

	public GUIStyle sliderBar;
	public GUIStyle sliderThumb;
	public GUIStyle TextStyle;
    private float savedSpeed = 0.0f;

	string p="";



	// Use this for initialization
	void Start () {
		MoveObject.runRate = runspeed;
        savedSpeed = PlayerPrefs.GetFloat("speed", 0.0f);
        runspeed = savedSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		MoveObject.runRate = runspeed;
	}

	void OnGUI ()
	{
		//write your GUI elements for one screen resolution, for example, 1280x720
		float scalex = (float)(Screen.width) / 800.0f;
		float scaley = (float)(Screen.height) / 480.0f;
			GUI.matrix = Matrix4x4.TRS(new Vector3(0, 0, 0), Quaternion.identity, new Vector3(scalex, scaley, 1));
            runspeed = GUI.VerticalSlider(new Rect(70, 200, 10, 220), runspeed , 0.6f, 0.0f, sliderBar, sliderThumb);
            PlayerPrefs.SetFloat("speed", runspeed);
		GUI.Label (new Rect (50, 150, 50,50),"Run Speed",TextStyle);
	}
}
