using UnityEngine;
using System.Collections;

public class NoButtonClick : MonoBehaviour {

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
		GameObject.FindGameObjectWithTag ("closemenu").renderer.enabled = false;
		GameObject.FindGameObjectWithTag ("closemenu").collider.enabled = false;
		GameObject.FindGameObjectWithTag ("bg").renderer.enabled = false;
		GameObject.FindGameObjectWithTag ("no").renderer.enabled = false;
		GameObject.FindGameObjectWithTag ("yes").renderer.enabled = false;
		GameObject.FindGameObjectWithTag ("no").collider.enabled = false;
		GameObject.FindGameObjectWithTag ("yes").collider.enabled = false;
		GameObject.FindGameObjectWithTag ("bg").collider.enabled = false;

        

        if (!Chances.isPlaying)
        {
            //BallCollider.Score = 0;
            //Chances.chances = 15;
        
        }
        else
        { 
		    MoveObject.GuiOn = false;
            Chances.gameOn = true;
		    Time.timeScale = 1;
        }
	}
}
