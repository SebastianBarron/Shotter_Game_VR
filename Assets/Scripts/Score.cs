using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	// Use this for initialization
	public Text txt;
	public int score;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		txt.text = "" + score;
	}

	public void updateScore(int deltaScore)
	{
		score += deltaScore;	
	}
}
