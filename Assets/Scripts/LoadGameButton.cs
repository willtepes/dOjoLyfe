using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadGameButton : MonoBehaviour {
	// Use this for initialization
	public AudioClip sound;
	public GameObject button;
	public Text dtext;
	public int index = 0;
	public bool nextButton =true;
	public string[] directions = new string[]{"Welcome to the Dojo","You are about to begin you journey towards becoming an awesome Software Developer.","Your Goal is to become the best programmer and to get a job at Boogle!","You can interact with characters in the game by pressing space bar.","Have fun Harry!"};
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
		changeText ();
		if (Input.GetButtonUp ("Submit")) {
			nextButton = true;
		}

	}
	public void startGame()
	{
		source.PlayOneShot (sound);
		button.SetActive (false);
		dtext.text = directions[index];
		//index = 0;
		//Application.LoadLevel(1);


	}
	public void changeText()
	{
		if (nextButton == true && Input.GetButtonDown ("Submit") ) {
			index += 1;
			if (index < directions.Length) {
				
				dtext.text = directions[index];

				nextButton = false;

			} else {
				Application.LoadLevel(1);
			}
		}
		
	}
}
