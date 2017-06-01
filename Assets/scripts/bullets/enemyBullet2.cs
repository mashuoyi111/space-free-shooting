using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBullet2 : MonoBehaviour {

	private float speed = 0.02f;
	private float life = 3f;
	// Use this for initialization
	void Start () {
		this.transform.up= (GameObject.Find ("playerSprite").transform.position-transform.position);
		this.gameObject.GetComponent<AudioSource>().Play();
		Destroy(this.gameObject, life);
	}

	// Update is called once per frame
	void Update () {
		if (speed < 0.1f) {
			this.transform.up = (GameObject.Find ("playerSprite").transform.position - transform.position);
		}
		transform.Translate(Vector2.up * speed);
		speed = speed * 1.02f;
	}
}
