using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {

	public Text t;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		variables.gameTime = Time.time - variables.gameTime;
		variables.score = variables.gameTime * 10f + variables.battlescore;
		t.text = Mathf.Round(variables.score).ToString();
	}
}
