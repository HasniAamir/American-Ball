using UnityEngine;
using System.Collections;

public class EndNoButtonClick : MonoBehaviour {

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
		BallCollider.Score = 0;
		Chances.chances = 15;
		Chances.gameOn = true;
		renderer.material.mainTexture = NormalTexture;
		MoveObject.GuiOn = false;
		Time.timeScale = 1;
		Application.LoadLevel (0);
	} 
}
