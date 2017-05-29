using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerAudioScriptFor2Player : MonoBehaviour {
	public GameObject timer;



	public void PlayEndOfTimerSound(){
		timer.GetComponent<AudioSource> ().Play ();
	}
}
