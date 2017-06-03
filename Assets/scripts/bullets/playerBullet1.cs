using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBullet1 : MonoBehaviour {

    // Use this for initialization

	void Start () {
		transform.localScale =new Vector3 (variables.playerBulletSize, variables.playerBulletSize, variables.playerBulletSize);
		Destroy(this.gameObject, variables.playerBulletLife);
	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Enemy") {
			variables.battlescore = variables.battlescore + 100f;
			Destroy (gameObject);
		}
	}
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector2.up * variables.playerBulletSpeed);
	}
}
