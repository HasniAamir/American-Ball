using UnityEngine;
using System.Collections;

public class DestroyBall : MonoBehaviour {

	public float destroyTime = 1.0f;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, destroyTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
