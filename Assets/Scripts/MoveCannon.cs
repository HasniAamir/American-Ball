using UnityEngine;
using System.Collections;

public class MoveCannon : MonoBehaviour {

	float value = 0.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time > value) 
		{
			
						value = Time.time + 0.5f;
						//transform.rotation = Quaternion.Euler (297.2632f, 0, Random.Range (-28, 28));
			//Vector3 from = Quaternion.Euler (297.2632f, 0, Random.Range (-28, 28));
			transform.rotation =  Quaternion.Slerp( transform.rotation, Quaternion.Euler (271f, 0, Random.Range (-22.4f, 22.4f)), Time.time*0.1f);
		}
	}
}
