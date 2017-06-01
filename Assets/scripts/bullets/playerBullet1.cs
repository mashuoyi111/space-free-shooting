using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBullet1 : MonoBehaviour {

    // Use this for initialization
    private float speed = 1f;
    private float life = 1f;

	void Start () {
        Destroy(this.gameObject, life);
	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Enemy") {
			variables.battlescore = variables.battlescore + 100f;
			Destroy (gameObject);
		}
	}
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.up * speed);
	}
}
