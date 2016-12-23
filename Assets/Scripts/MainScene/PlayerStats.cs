using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

	static public double Motivation;

	static public double CodingSkill;

	static public double Algorithms;

	static public double PlatformSkill;

	static public double ProjectCompletion;

    static public double TimeLeft;

	static public double finalScore;

    // Use this for initialization
    void Awake () {
		Motivation = 10;
		Algorithms = 0;
		PlatformSkill = 0;
		ProjectCompletion = 0;
        TimeLeft = 100;
        ChangeCoding();
		DontDestroyOnLoad (transform.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void ChangeMotivation(double MotivationValue)
    {
        double Banana = Random.Range(1, 11);
        if (Banana <=5)
        {
            Motivation += MotivationValue;
        }
        else
        {
            Motivation += (MotivationValue * 2);
        }
    }

    public static void ChangeAlgorithms(double AlgorithmValue)
    {
        if(Motivation > 100)
        {
            Algorithms += (AlgorithmValue * 2);
        }
        else if(Motivation > 50)
        {
            Algorithms += (AlgorithmValue * 1.5);
        }
        else
        {
            Algorithms += AlgorithmValue;
        }
        if(TimeLeft > 66)
        {
            Algorithms += 3;
        }
        Motivation -= 3;
        ChangeCoding();
    }

    public static void ChangePlatform(double PlatformValue)
    {
        if (Motivation > 110)
        {
            PlatformSkill += (PlatformValue * 2);
        }
        else if (Motivation > 70)
        {
            PlatformSkill += (PlatformValue * 1.5);
        }
        else
        {
			PlatformSkill += PlatformValue;
        }
        if (TimeLeft > 33 && TimeLeft < 66)
        {
            PlatformSkill += 5;
        }
        Motivation -= 3;
        ChangeCoding();
    }

    public static void AddToProject(double ProjectValue)
    {
        if (Motivation > 120)
        {
            ProjectCompletion += (ProjectValue * 2);
        }
        else if (Motivation > 60)
        {
            ProjectCompletion += (ProjectValue * 1.5);
        }
        else
        {
            ProjectCompletion += ProjectValue;
        }
        if (TimeLeft < 33)
        {
            ProjectCompletion += 5;
        }
        Motivation -= 3;
    }

    public static void ChangeCoding()
    {
        CodingSkill = (Algorithms + PlatformSkill) / 2;
    }

    public static void CodeReview(double PlatformValue)
    {
        if (Motivation > 60)
        {
            PlatformSkill += (PlatformValue * 1.5);
        }
        else if (Motivation > 40)
        {
            PlatformSkill += (PlatformValue * 1);
        }
        else
        {
            PlatformSkill += (PlatformValue *.5);
        }
        if (TimeLeft > 33 && TimeLeft < 66)
        {
            PlatformSkill += 5;
        }
        Motivation -= 3;
        ChangeCoding();
    }

    public static void ParseStone(double MotivationValue)
    {
        Motivation -= 5;
    }

    public static void HackerRank(double AlgorithmValue)
    {
        if (Motivation > 80)
        {
            Algorithms += (AlgorithmValue * 2);
        }
        else if (Motivation > 40)
        {
            Algorithms += (AlgorithmValue * 1.5);
        }
        else
        {
            Algorithms += AlgorithmValue;
        }
        if (TimeLeft > 66)
        {
            Algorithms += 3;
        }
        Motivation -= 3;
        ChangeCoding();
    }

    public static void ChangeTime(double Time)
    {
        int bonus = 1;
        TimeLeft -= Time;
		if (TimeLeft <= 0) {
			if (ProjectCompletion >= 100) {
				bonus = 2;
			}
			finalScore = (double) ((((Algorithms * 6)+1) * ((PlatformSkill * 2.5)+1)) * bonus);
			GameObject Hud =GameObject.Find("Hud");
			Hud.SetActive (false);

			
			Application.LoadLevel (2);
		}
		else
		{
			PlatformEvent.UpdateUI ();
		}
    }
}
    