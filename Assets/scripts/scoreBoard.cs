using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreBoard : MonoBehaviour {

	public Text t;
	public Text l;
	public Text g;
	// Use this for initialization
	void Start () {
		t.text = variables.score.ToString ();
		l.text = variables.currentLevel.ToString();
		string grade = "Ranking: ";
		if (variables.score < 500) {
			grade += "F";
		} else if (variables.score < 1000) {
			grade += "D-";
		} else if (variables.score < 1500) {
			grade += "D+";
		} else if (variables.score < 2000) {
			grade += "C-";
		} else if (variables.score < 2500) {
			grade += "C+";
		} else if (variables.score < 3000) {
			grade += "B-";
		} else if (variables.score < 3500) {
			grade += "B+";
		} else if (variables.score < 4000) {
			grade += "A-";
		} else if (variables.score < 4500) {
			grade += "A+";
		} else if (variables.score < 5000) {
			grade += "S";
		} else if (variables.score < 5500) {
			grade += "SS";
		} else {
			grade += "SSS";
		}
		g.text = grade;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
