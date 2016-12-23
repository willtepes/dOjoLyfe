using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class DialogueManager : MonoBehaviour {
	public GameObject dbox;
	public Text dtext;
	public bool dialogueActive;

	// Use this for initialization
	void Start () {
		dbox.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if(dialogueActive && Input.GetKeyDown(KeyCode.Space))
		{
			
			dbox.SetActive(false);
			dialogueActive = false;
			PlayerMovement.canmove = true;
		}
	}

	public void ShowBox(string dialogue)
	{
		PlayerMovement.canmove = false;
		dialogueActive = true;
		dbox.SetActive(true);
		dtext.text = dialogue;
	}

	
}
