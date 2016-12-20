using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudScript : MonoBehaviour {

	public Text Motivation;
	public Text CodingSkill;
	public Text ProjectCompletion;
	void RenderUI()
	{
		Motivation.text = "Motivation:" + PlayerStats.Motivation.ToString();
		CodingSkill.text = "Coding Skill:" + PlayerStats.CodingSkill.ToString();
		ProjectCompletion.text = "Project Completion:" + PlayerStats.ProjectCompletion.ToString();
	}
	

	// Use this for initialization
	void Start () {
		RenderUI();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
