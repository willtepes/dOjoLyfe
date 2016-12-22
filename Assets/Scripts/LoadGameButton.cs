using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGameButton : MonoBehaviour {
	// Use this for initialization
	public AudioClip sound;
	private AudioSource source {get{return GetComponent<AudioSource>();}}
	void Awake()
	{
		gameObject.AddComponent<AudioSource> ();
		source.clip = sound;
	}
	public void startGame()
	{
		source.PlayOneShot (sound);

		Application.LoadLevel(1);


	}
}
