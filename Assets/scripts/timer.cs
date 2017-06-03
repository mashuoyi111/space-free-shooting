using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {

	public Text t;
	// Use this for initialization
	void Start () {
		
	}

	public void stopTimer(){
		this.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		variables.gameTime = Time.time- variables.startTime;
		variables.score = Mathf.Round (variables.gameTime * 10f + variables.battlescore);
		t.text =variables.score.ToString();
	}
}
