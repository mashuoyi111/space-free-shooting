using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreBoard : MonoBehaviour {

	public Text t;
	// Use this for initialization
	void Start () {
		t.text = variables.score.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
