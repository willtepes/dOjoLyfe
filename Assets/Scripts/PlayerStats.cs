using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

	static public int Motivation;
	static public int CodingSkill;

	static public int Algorithms;

	static public int PlatformSkill;

	static public int ProjectCompletion;



	// Use this for initialization
	void Awake () {
		Motivation = 10;
		Algorithms = 0;
		PlatformSkill = 0;
		ProjectCompletion = 0;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
