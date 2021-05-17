using UnityEngine;
using System.Collections;

public class Chances : MonoBehaviour {
	public static int chances = 15;
	public TextMesh dropsText = null; 
	Vector3 PointA;
	Vector3 PointB;
    InterstitialAds x;
	public static bool gameOn = true;
    public static bool isPlaying = false;

	// Use this for initialization
	void Start () {
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
		//BallCollider.displayText1 = "Chances "+chances;
		dropsText.text = "Drops " + chances;
        isPlaying = true;
        x = (InterstitialAds)GameObject.Find("InterstitialPrefab").GetComponent("InterstitialAds");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			//GameObject.FindGameObjectWithTag ("closemenu").SetActive (true);
			GameObject.FindGameObjectWithTag ("closemenu").renderer.enabled = true;
			GameObject.FindGameObjectWithTag ("yes").renderer.enabled = true;
			GameObject.FindGameObjectWithTag ("no").renderer.enabled = true;
			GameObject.FindGameObjectWithTag ("yes").collider.enabled = true;
			GameObject.FindGameObjectWithTag ("no").collider.enabled = true;
			GameObject.FindGameObjectWithTag ("bg").renderer.enabled = true;
            x.showInterstitial();
			//GameObject.FindGameObjectWithTag ("yes").SetActive (true);
			//GameObject.FindGameObjectWithTag ("no").SetActive (true);
			MoveObject.GuiOn = true;
			Time.timeScale = 0;
			
		}
	}

	IEnumerator OnCollisionEnter(Collision c)
	{
		if (c.gameObject.tag == "ball") {
			chances--;
			//BallCollider.displayText1 = "Chances "+chances;
			dropsText.text = "Drops " + chances;
			Destroy(c.gameObject);

			if(chances <= 0)
			{
				/*GameObject.FindGameObjectWithTag ("gameend").renderer.enabled = true;

				GameObject.FindGameObjectWithTag ("gui1").renderer.enabled = true;
				GameObject.FindGameObjectWithTag ("gui2").renderer.enabled = true;
				GameObject.FindGameObjectWithTag ("endyes").renderer.enabled = true;
				GameObject.FindGameObjectWithTag ("endno").renderer.enabled = true;
				GameObject.FindGameObjectWithTag ("score").renderer.enabled = true;
				GameObject.FindGameObjectWithTag ("bg").renderer.enabled = true;
				GameObject.FindGameObjectWithTag ("endyes").collider.enabled = true;
				GameObject.FindGameObjectWithTag ("endno").collider.enabled = true;*/
				//GameObject.FindGameObjectWithTag ("endyes").SetActive (true);
				//GameObject.FindGameObjectWithTag ("endno").SetActive (true);

				GameObject.FindGameObjectWithTag ("gui2").renderer.enabled = true;
				GameObject.FindGameObjectWithTag ("endyes").renderer.enabled = true;
				GameObject.FindGameObjectWithTag ("endno").renderer.enabled = true;
				GameObject.FindGameObjectWithTag ("endyes").collider.enabled = true;
				GameObject.FindGameObjectWithTag ("endno").collider.enabled = true;

				GameObject.FindGameObjectWithTag ("lhand").renderer.enabled = false;

				GameObject.FindGameObjectWithTag ("rhand").renderer.enabled = false;

				PointA = GameObject.FindGameObjectWithTag ("MainCamera").transform.position;
				PointB = GameObject.FindGameObjectWithTag ("CameraTo").transform.position;

				yield return StartCoroutine(MoveCamera(GameObject.FindGameObjectWithTag("MainCamera").transform, PointA, PointB, 1.0f));
				//yield return StartCoroutine(MoveObject(GameObject.FindGameObjectWithTag("hands").transform, pointB, pointA, 0.4f));
				GameObject.FindGameObjectWithTag ("MainCamera").transform.position = GameObject.FindGameObjectWithTag ("CameraTo").transform.position;
				dropsText.text = "Drops " + 0;
				Time.timeScale = 0;
				gameOn = false;
                isPlaying = false;
				MoveObject.GuiOn = true;
				//GameObject.FindGameObjectWithTag ("closemenu").SetActive (true);

			}
		}
	}

	IEnumerator MoveCamera (Transform thisTransform, Vector3 startPos, Vector3 endPos, float time) {
		float i = 0.0f;
		float rate = 1.0f / time;
		
		while (i < 1.0f) {
			i += Time.deltaTime * rate;
			thisTransform.position = Vector3.Lerp(startPos, endPos, i);
			yield return null; 
		}
	}

}
