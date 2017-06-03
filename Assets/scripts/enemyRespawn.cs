using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyRespawn : MonoBehaviour {

	public Transform enemy1;
	public Transform enemy2;
	public Transform enemyScatter;
	public Text level;

	// Use this for initialization
	void Start () {
		level.text="1";
		respawn ();
		respawn ();
		InvokeRepeating ("respawn", variables.MinRespawnRate, variables.MinRespawnRate);
		InvokeRepeating ("inceaseLevel", variables.IncreaseDifficultyInterval, variables.IncreaseDifficultyInterval);
	}

	void inceaseLevel () {
		CancelInvoke ();
		variables.currentLevel++;
		variables.MaxEnemies = variables.MaxEnemies + 2;
		variables.MinRespawnRate = variables.MinRespawnRate * 0.8f;
		level.text = variables.currentLevel.ToString ();
		InvokeRepeating ("respawn", variables.MinRespawnRate, variables.MinRespawnRate);
		InvokeRepeating ("inceaseLevel", variables.IncreaseDifficultyInterval, variables.IncreaseDifficultyInterval);
	}



	// how enemies will be respawned
	void respawn () {
		if (GameObject.FindGameObjectsWithTag ("Enemy").Length < variables.MaxEnemies) {

			string resultPosString="";
			do {
				int resultPos = Random.Range (0, 4);
				switch (resultPos) {
				case 0:
					resultPosString = "respawnPoint1";
					break;
				case 1:
					resultPosString = "respawnPoint2";
					break;
				case 2:
					resultPosString = "respawnPoint3";
					break;
				case 3:
					resultPosString = "respawnPoint4";
					break;
				}
			} while(Vector3.Distance (GameObject.Find (resultPosString).transform.position, GameObject.Find ("playerSprite").transform.position) < 15);


			int resultEnemy=Random.Range (0, 3);
			switch (resultEnemy) {
			case 0:
				Instantiate (enemy1, GameObject.Find (resultPosString).transform.position, new Quaternion (0, 0, 0, 0));
				break;
			case 1:
				Instantiate (enemy2, GameObject.Find (resultPosString).transform.position, new Quaternion (0, 0, 0, 0));
				break;
			case 2:
				Instantiate (enemyScatter, GameObject.Find (resultPosString).transform.position, new Quaternion (0, 0, 0, 0));
				break;
			}

		}
	}
}
