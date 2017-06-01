using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyBulletGeneral : MonoBehaviour {


	// Use this for initialization
	void OnTriggerEnter2D(Collider2D col){
		
		if (col.gameObject.tag == "Player") {
			Camera.main.transform.parent=null;
			col.gameObject.GetComponent<Renderer> ().material.color = new Color (1.0f, 1.0f, 1.0f, 0f);
			Destroy(col.gameObject.GetComponent<MonoBehaviour> ());
			StartCoroutine(goGameOverAfterDeath ());
		}
	}

	IEnumerator goGameOverAfterDeath(){
		yield return new WaitForSeconds (1.5f);
		SceneManager.LoadScene ("gameover");
	}

	void Update(){

	}
}
