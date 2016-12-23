using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudScript : MonoBehaviour {

	public Text Motivation;
	public Text CodingSkill;
	public Text ProjectCompletion;
    public Text TimeLeft;

	void RenderUI()
	{
		Motivation.text = "Motivation: " + PlayerStats.Motivation.ToString();
		CodingSkill.text = "Coding Skill: " + PlayerStats.CodingSkill.ToString();
		ProjectCompletion.text = "Project Completion: " + PlayerStats.ProjectCompletion.ToString() + "%";
        TimeLeft.text = "TimeLeft: " + PlayerStats.TimeLeft.ToString();
	}
	

	// Use this for initialization
	void Awake () {
        RenderUI();
        PlatformEvent.dotheUpdateUI += RenderUI;
		gameObject.SetActive (true);

	}
	void OnDestroy()
	{
		PlatformEvent.dotheUpdateUI -= RenderUI;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("escape")) {//When a key is pressed down it see if it was the escape key if it was it will execute the code
			Application.Quit(); // Quits the game
		}
	}
}
