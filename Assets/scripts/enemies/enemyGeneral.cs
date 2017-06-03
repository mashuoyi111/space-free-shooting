using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyGeneral : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "playerBullet") {
			this.gameObject.GetComponent<AudioSource>().Play();
			Vector3 temp = this.transform.position;
			transform.Translate(Vector3.forward*-30);
			transform.Translate(Vector3.up*-1000);
			variables.currentKilled++;

			//drop upgrade packages
			if(variables.currentKilled>=variables.enemyKilledToGetUpgrade){
				int upgrade = Random.Range (0, 4);
				switch (upgrade) {
				case 0:
					Instantiate (Resources.Load("bulletSize"), temp, new Quaternion (0, 0, 0, 0));
					break;
				case 1:
					Instantiate (Resources.Load("bulletSpeed"), temp, new Quaternion (0, 0, 0, 0));
					break;
				case 2:
					Instantiate (Resources.Load("fireRate"), temp, new Quaternion (0, 0, 0, 0));
					break;
				case 3:
					Instantiate (Resources.Load("bulletRange"), temp, new Quaternion (0, 0, 0, 0));
					break;
				}
				variables.currentKilled = 0;
				variables.enemyKilledToGetUpgrade = variables.enemyKilledToGetUpgrade + 1;

			}

			Destroy (this.gameObject,1.5f);
		}

	}
}
