using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventDialog : MonoBehaviour {
	Text dialog;
	int someTime;
	string somtetag;
	protected Button yesbtn;
	protected Button nobtn1;

	void Awake()
	{
		yesbtn = this.gameObject.GetComponentsInChildren<Button>()[1];
		yesbtn.onClick.AddListener(TaskOnClick);
		nobtn1 = this.gameObject.GetComponentsInChildren<Button>()[0];
		nobtn1.onClick.AddListener(TaskOnClick1);
		dialog = this.gameObject.GetComponentsInChildren<Text>()[0];
		gameObject.SetActive (false);
		PlayerEvents.PlayerEvent += DisplayDialog;

	}

	void DisplayDialog(string tag, int Time)
	{
		PlayerMovement.canmove = false;
		somtetag = tag;
		someTime = Time;

		switch (tag) {
		case "whiteboard":
			dialog.text = "Wanna Do some Algorithms???";
			break;
		case "platform":
			dialog.text = "Wanna work on the plaform???";
			break;
		case "project":
			dialog.text = "Do Your Project???!!!?";
			break;
		case "NapTimewifSal":
			dialog.text = "Sal will be little spoon???";
			break;
		default:
			break;
		

		}
		gameObject.SetActive (true);
	}



	public void TaskOnClick(){
			

		PlayerEvents.doSomeStuff (somtetag, someTime);
		gameObject.SetActive (false);
		PlayerMovement.canmove = true;

	}

	public void TaskOnClick1(){
		gameObject.SetActive (false);
		PlayerMovement.canmove = true;
	}


}

