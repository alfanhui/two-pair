using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveAnotherClueGameCheckScript : MonoBehaviour {

	private bool hasAnotherClueGame;
	public Animator TimerAnim;

	public bool HasAnotherClueGame{
		get{return hasAnotherClueGame;}
		set{ hasAnotherClueGame = value; }
	}

	public void setTrueGiveAnotherClueOnTimer(){
		if (hasAnotherClueGame) {
			GetComponent<Animator> ().SetBool ("GiveAnotherClue", true);
			//TimerAnim.SetBool ("GiveAnotherClueOnTimer", true); //Stops the timer from repeating on start button.
		}
	}

}
