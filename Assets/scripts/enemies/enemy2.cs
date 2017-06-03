using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2 : MonoBehaviour {

	public Transform bullet;
	private int numToRun=80;
	private float cooldown = 0f;

	// Use this for initialization
	void Start () {

	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Wall") {
			transform.Rotate (0,0, 180);
			numToRun = Random.Range(60,120);
		}
	}

	// Update is called once per frame
	void Update () {
		if (numToRun <= 0) {

			transform.Rotate (0, 0, Random.Range (-180, 180));
			numToRun = Random.Range(40,100);
			if (Vector3.Distance (GameObject.Find ("playerSprite").transform.position, gameObject.transform.position) > 20) {
				this.transform.up= (GameObject.Find ("playerSprite").transform.position-transform.position);
				transform.Rotate (0, 0, Random.Range (-30, 30));
			}
		}


		if (cooldown <= 0f && Vector3.Distance (GameObject.Find ("playerSprite").transform.position, gameObject.transform.position) < 17) {
			cooldown = Random.Range(variables.enemyFireRate-10f,variables.enemyFireRate+10f)*1.2f;
			Instantiate (bullet,gameObject.transform.position,Quaternion.Euler(0, 0, 0));
		}
		transform.Translate(Vector2.up * variables.enemySpeed*1.2f);
		numToRun--;
		cooldown--;
	}
}
