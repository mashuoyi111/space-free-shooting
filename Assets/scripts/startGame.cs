using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour {


	public void easygame(){
		variables.enemyFireRate = 120f;
		variables.enemySpeed=0.10f;
		variables.MinRespawnRate = 10f;
		SceneManager.LoadScene ("mainGame");
	}
	public void mediumgame(){
		variables.enemyFireRate = 100f;
		variables.enemySpeed=0.12f;
		variables.MinRespawnRate = 8f;
		SceneManager.LoadScene ("mainGame");
	}
	public void hardgame(){
		variables.enemyFireRate = 80f;
		variables.enemySpeed=0.14f;
		variables.MinRespawnRate = 6f;
		SceneManager.LoadScene ("mainGame");
	}
	public void exit(){
		Application.Quit ();
	}

}
