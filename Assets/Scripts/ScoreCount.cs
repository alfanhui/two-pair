using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ScoreCount : MonoBehaviour {

	int tempScore;

	public void ResetScore(){
		gameObject.GetComponent<Text>().text = "0";
	}

	public void IncrementScore(){
		tempScore = Convert.ToInt32 (gameObject.GetComponent<Text>().text);
		tempScore++;
		gameObject.GetComponent<Text>().text = Convert.ToString(tempScore);
	}

	public void DecrementScore(){
		tempScore = Convert.ToInt32 (gameObject.GetComponent<Text>().text);
		tempScore--;
		gameObject.GetComponent<Text>().text = Convert.ToString(tempScore);
	}
}
