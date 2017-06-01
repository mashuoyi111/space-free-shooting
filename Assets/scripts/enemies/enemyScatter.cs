using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScatter : MonoBehaviour {

	public Transform bullet;
	private int numToRun=80;
	private float cooldown = 0f;

	// Use this for initialization
	void Start () {

	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "playerBullet") {
			this.gameObject.GetComponent<AudioSource>().Play();
			transform.Translate(Vector3.forward*-30);
			transform.Translate(Vector3.up*-1000);
			Destroy (this.gameObject,1.5f);
		}
		if (col.gameObject.tag == "Wall") {
			transform.Rotate (0,0, 180);
			numToRun = Random.Range(60,100);
		}
	}

	// Update is called once per frame
	void Update () {
		if (numToRun <= 0) {

			transform.Rotate (0, 0, Random.Range (-180, 180));
			numToRun = Random.Range(30,70);
		}
		if(Vector3.Distance(GameObject.Find ("playerSprite").transform.position, gameObject.transform.position) > 30){
			this.transform.up= (GameObject.Find ("playerSprite").transform.position-transform.position);
		}

		if (cooldown <= 0f && Vector3.Distance (GameObject.Find ("playerSprite").transform.position, gameObject.transform.position) < 15) {
			cooldown = Random.Range(variables.enemyFireRate-10f,variables.enemyFireRate+10f)*1.2f;
			Transform one= (Transform) Instantiate (bullet,gameObject.transform.position,Quaternion.Euler(0, 0, 0));
			Transform two= (Transform) Instantiate (bullet,gameObject.transform.position,Quaternion.Euler(0, 0, 0));
			Transform three= (Transform) Instantiate (bullet,gameObject.transform.position,Quaternion.Euler(0, 0, 0));
			one.transform.up=(GameObject.Find ("playerSprite").transform.position-one.transform.position);
			two.transform.up=(GameObject.Find ("playerSprite").transform.position-two.transform.position);
			two.Rotate (Vector3.forward * 10);
			three.transform.up=(GameObject.Find ("playerSprite").transform.position-three.transform.position);
			three.Rotate (Vector3.forward * -10);
		}
		transform.Translate(Vector2.up * variables.enemySpeed*1.6f);
		numToRun--;
		cooldown--;
	}
}
