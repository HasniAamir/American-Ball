using UnityEngine;
using System.Collections;

public class BackButtonScript : MonoBehaviour {

	public Texture2D NormalTexture;
	public Texture2D PressedTexture;
	
	// Use this for initialization
	void Start () {
		renderer.material.mainTexture = NormalTexture;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseDown(){
		renderer.material.mainTexture = PressedTexture;
	}
	
	void OnMouseUp(){
		
		renderer.material.mainTexture = NormalTexture;
		GameObject.FindGameObjectWithTag ("board").renderer.enabled = false;
		GameObject.FindGameObjectWithTag ("bg").renderer.enabled = false;
		GameObject.FindGameObjectWithTag ("backbt").renderer.enabled = false;
		GameObject.FindGameObjectWithTag ("gui3").renderer.enabled = false;
		GameObject.FindGameObjectWithTag ("gui4").renderer.enabled = false;
		GameObject.FindGameObjectWithTag ("gui5").renderer.enabled = false;
		
		GameObject.FindGameObjectWithTag ("board").collider.enabled = false;
		GameObject.FindGameObjectWithTag ("bg").collider.enabled = false;
		GameObject.FindGameObjectWithTag ("backbt").collider.enabled = false;
	} 
}
