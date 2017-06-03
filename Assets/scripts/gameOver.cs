using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour {

    public void restart(){
		variables.score = 0f;
		variables.gameTime = 0f;
		variables.battlescore = 0f;
		variables.currentLevel = 1;
		variables.enemyKilledToGetUpgrade=2;
		variables.currentKilled=0;
		variables.startTime = Time.time;
        SceneManager.LoadScene("mainGame");
    }

	public void mainMenu(){
		variables.score = 0f;
		variables.gameTime = 0f;
		variables.battlescore = 0f;
		variables.currentLevel = 1;
		variables.enemyKilledToGetUpgrade=2;
		variables.currentKilled=0;
		variables.startTime = Time.time;
		SceneManager.LoadScene("startMenu");

	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
