using UnityEngine;
using System.Collections;

public class YesButtonClick : MonoBehaviour {

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
		Application.Quit ();
	} 
}
