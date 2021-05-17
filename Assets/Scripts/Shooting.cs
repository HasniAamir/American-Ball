using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

	public int bulletSpeed = 0 ;
	public Transform Bullet;
	public AudioClip gunSound;
	public float FireRate = 2.0f;
	float nextFire = 2.0f;
	// Use this for initialization
	void Start () {
        //vibertest.Instantiate();
	}
	
	// Update is called once per frame
	void Update () {
		
	if (Chances.gameOn) {
        
						if (FireRate < 1.0f) {
								FireRate = 1.0f;
						} else {
								FireRate = FireRate - 0.0003f;
						}
						if (Time.time > nextFire) {
								Transform b1 = Instantiate (Bullet, transform.position, Quaternion.identity) as Transform;
                                //vibertest.EnableViber(26);
								b1.rigidbody.AddForce (transform.forward * bulletSpeed);
								audio.PlayOneShot (gunSound);
								nextFire = Time.time + FireRate;

						}
				}

	}
}
