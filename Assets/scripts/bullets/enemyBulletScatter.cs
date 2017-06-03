using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBulletScatter : MonoBehaviour {

	private float speed = 0.12f;
	private float life = 2.5f;
	// Use this for initialization
	void Start () {
		this.gameObject.GetComponent<AudioSource>().Play();
		//transform.up=(GameObject.Find ("playerSprite").transform.position-transform.position);
		Destroy(this.gameObject, life);
	}

	// Update is called once per frame
	void Update () {
		transform.Translate(Vector2.up * speed);
	}
}
