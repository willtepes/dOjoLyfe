using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class DialogueManager : MonoBehaviour {
	public GameObject dbox;
	public Text dtext;
	public bool dialogueActive;

	// Dialogue box is set inactive at initialization 
	void Start () {
		dbox.SetActive(false);
	}
	
	// Update is called once per frame - clears dialogue box if active and lets player move after submit button clicked
	void Update () {
		if(dialogueActive && Input.GetButtonDown("Submit"))
		{
			
			dbox.SetActive(false);
			dialogueActive = false;
			PlayerMovement.canmove = true;
		}
	}

	// Freezes player in place and puts dialogue box on screen.  Sets dialogueActive bool to true so it can be cleared with Update.
	public void ShowBox(string dialogue)
	{
		PlayerMovement.canmove = false;
		dialogueActive = true;
		dbox.SetActive(true);
		dtext.text = dialogue;
	}

	
}
