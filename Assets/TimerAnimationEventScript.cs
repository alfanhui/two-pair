using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerAnimationEventScript : MonoBehaviour {

	public void ToggleAnimationParameterAnotherClue(){
		bool giveAnotherClueOnTimer = GetComponent<Animator> ().GetBool ("GiveAnotherClueOnTimer");
		GetComponent<Animator>().SetBool("GiveAnotherClueOnTimer", !giveAnotherClueOnTimer);
	}
}
