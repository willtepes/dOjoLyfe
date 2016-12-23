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
		DontDestroyOnLoad (transform.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
