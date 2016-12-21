using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

	static public int Motivation;

	static public int CodingSkill;

	static public int Algorithms;

	static public int PlatformSkill;

	static public int ProjectCompletion;

    static public int TimeLeft;

	// Use this for initialization
	void Awake () {
		Motivation = 10;
		Algorithms = 0;
		PlatformSkill = 0;
		ProjectCompletion = 0;
        TimeLeft = 100;
        ChangeCoding();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public static void ChangeMotivation(int MotivationValue)
    {
        Motivation += MotivationValue;
    }

    public static void ChangeAlgorithms(int AlgorithmValue)
    {
        Algorithms += AlgorithmValue;
        ChangeCoding();
    }

    public static void ChangePlatform(int PlatformValue)
    {
        PlatformSkill += PlatformValue;
        ChangeCoding();
    }

    public static void AddToProject(int ProjectValue)
    {
        ProjectCompletion += ProjectValue;
    }

    public static void ChangeCoding()
    {
        CodingSkill = (Algorithms + PlatformSkill) / 2;
    }

    public static void ChangeTime(int Time)
    {
        TimeLeft -= Time;
        PlatformEvent.UpdateUI();
    }
}
