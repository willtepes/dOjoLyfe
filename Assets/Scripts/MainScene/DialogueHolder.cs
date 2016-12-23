using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueHolder : MonoBehaviour {

	public string dialogue1;
	public string dialogue2;

	public bool canInteract = false;

	public string dialogue3;
	private string dialogue;
	public  DialogueManager dMan;

	// Use this for initialization
	void Start () {
		var manObj = GameObject.FindGameObjectWithTag("DialogueManager");
		dMan = manObj.GetComponent<DialogueManager>();
	}

	// Update is called once per frame
	void Update () {
		if(canInteract == true && Input.GetKeyUp(KeyCode.Space)){
			showDialouge();
		}
	}


	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Player")
		{
			canInteract = true;
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if(other.tag == "Player")
		{
			canInteract = false;
		}
	}

	void showDialouge(){
		if(PlayerStats.TimeLeft > 66)
		{
			dialogue = dialogue1;
		}else if(PlayerStats.TimeLeft > 33){
			dialogue = dialogue2;
		}else{
			dialogue = dialogue3;
		}
		dMan.ShowBox(dialogue);
		canInteract = false;
	}
}
