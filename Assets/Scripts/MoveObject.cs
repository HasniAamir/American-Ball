using UnityEngine;
using System.Collections;

public class MoveObject : MonoBehaviour {

	public Transform relativeTo;
	public static bool GuiOn = false;

	public static float runRate = 0.0f;
	float runSpeed = 0.0f;

	//For walking effect
	public float amount = 10.0f;
	public float speed = 1.0f;
	private Vector3 lastPos;
	private float dist = 0.0f;
	private Vector3 rotation = Vector3.zero;

	// Use this for initialization
	void Start () {
		lastPos = transform.position;
		GameObject.FindGameObjectWithTag ("closemenu").renderer.enabled = false;
		GameObject.FindGameObjectWithTag ("closemenu").collider.enabled = false;

		GameObject.FindGameObjectWithTag ("bg").renderer.enabled = false;
		GameObject.FindGameObjectWithTag ("no").renderer.enabled = false;
		GameObject.FindGameObjectWithTag ("no").collider.enabled = false;

		GameObject.FindGameObjectWithTag ("yes").renderer.enabled = false;
		GameObject.FindGameObjectWithTag ("yes").collider.enabled = false;

		//GameObject.FindGameObjectWithTag ("no").SetActive (false);
		//GameObject.FindGameObjectWithTag ("yes").SetActive (false);

		//GameObject.FindGameObjectWithTag ("gameend").renderer.enabled = false;
		//GameObject.FindGameObjectWithTag ("gui1").renderer.enabled = false;
		GameObject.FindGameObjectWithTag ("gui2").renderer.enabled = false;
		GameObject.FindGameObjectWithTag ("endyes").renderer.enabled = false;
		GameObject.FindGameObjectWithTag ("endno").renderer.enabled = false;
		GameObject.FindGameObjectWithTag ("endyes").collider.enabled = false;
		GameObject.FindGameObjectWithTag ("bg").collider.enabled = false;
		GameObject.FindGameObjectWithTag ("endno").collider.enabled = false;
		//GameObject.FindGameObjectWithTag ("score").renderer.enabled = false;
		//GameObject.FindGameObjectWithTag ("endyes").SetActive (false);
		//GameObject.FindGameObjectWithTag ("endno").SetActive (false);
		//GameObject.FindGameObjectWithTag ("closemenu").SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {
		//displayText =  Input.acceleration.x + "\n" + Input.acceleration.y+ "\n" +Input.acceleration.z;
		//displayText = Time.deltaTime + "";
		//For Position



		if (!GuiOn) {
						Vector3 temp = transform.position;
						if (temp.x > 84)
								temp.x = 84f;
						if (temp.x < 16)
								temp.x = 16f;

						temp.y = 4.41f;
						temp.z = -1.08f;
			
						transform.position = temp;
						if (temp.x < 82 && temp.x > 18) {



								rotation = Vector3.zero;
								//For Walking Effect
								dist += (transform.position - lastPos).magnitude;
								lastPos = transform.position;
								rotation.z = Mathf.Sin (dist * speed) * amount;
								transform.localEulerAngles = rotation;
						} else {
								rotation = Vector3.zero;
								transform.localEulerAngles = rotation;
						}
			if(Input.acceleration.x<0)
				runSpeed = Input.acceleration.x+(runRate*-1);
			else
				runSpeed = Input.acceleration.x+runRate;
			transform.Translate (runSpeed, 0, 0);
				
			}



	}



}
