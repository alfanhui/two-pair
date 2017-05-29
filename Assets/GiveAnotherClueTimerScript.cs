using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveAnotherClueTimerScript : MonoBehaviour {

	public Animator WordAnim;


	public void SetFlaseAnimationParameterAnotherClue(){
		WordAnim.SetBool("GiveAnotherClue", false);
		GetComponent<Animator> ().SetBool ("GiveAnotherClueOnTimer", false);
	}


	public void PlayEndOfTimerSound(){
		GetComponent<AudioSource> ().Play ();
	}

}
