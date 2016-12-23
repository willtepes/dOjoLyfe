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
	void Update () {
		if(Input.GetKeyDown("escape")) {//When a key is pressed down it see if it was the escape key if it was it will execute the code
			Application.Quit(); // Quits the game
		}
	}
	public void startGame()
	{
		source.PlayOneShot (sound);

		Application.LoadLevel(1);


	}
}
