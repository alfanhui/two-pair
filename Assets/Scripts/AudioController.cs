using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour {

	private Object[] musicClips;
	private Object[] soundClips;
	private bool ToggleMusic = false;

	void Awake(){
		musicClips = Resources.LoadAll ("Music", typeof(AudioClip));
		soundClips = Resources.LoadAll ("SFX", typeof(AudioClip));
	}

	public void PlayRandomMusic(){
		ToggleMusic = true;
		GetComponent<AudioSource> ().clip = musicClips [Random.Range (0, musicClips.Length)]as AudioClip;
		StartCoroutine (DurationOfMusic ());
		GetComponent<AudioSource>().Play ();
	}

	IEnumerator DurationOfMusic(){
		yield return new WaitForSeconds (GetComponent<AudioSource>().clip.length);
		if(ToggleMusic)
			PlayRandomMusic ();
	}

	public void StopMusic(){
		if (ToggleMusic) {
			StopCoroutine (DurationOfMusic ());
			GetComponent<AudioSource> ().Stop ();
			ToggleMusic = false;
		}
	}



}
