using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotSpeedUpgrade : MonoBehaviour {

	private float speed=0.05f;
	private int numToRun=80;
	// Use this for initialization
	void Start () {
		
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Player") {
			if (variables.fireRate > 5f) {
				variables.fireRate = variables.fireRate * 0.8f;
			}
			this.gameObject.GetComponent<AudioSource>().Play();
			transform.Translate(Vector3.forward*-30);
			transform.Translate(Vector3.up*-1000);
			Destroy (this.gameObject,1);
		}
		if (col.gameObject.tag == "Wall") {
			transform.Rotate (0,0, 180);
			numToRun = Random.Range(60,120);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (numToRun <= 0) {
			
			transform.Rotate (0, 0, Random.Range (-180, 180));
			numToRun = 80;
		}
		transform.Translate(Vector2.up * speed);
		numToRun--;
	}

}
