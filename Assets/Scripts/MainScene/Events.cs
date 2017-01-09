using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Events : MonoBehaviour {
	public int algo;
	public int plat;
	public int proj;
	public int mot;
	void Awake()
	{
		PlayerEvents.shesaidYes += SwitchCase;
	}

	void SwitchCase(string tag, int timeUsed)
	{
		
		switch (tag) {
		case "whiteboard":
			PlayerStats.ChangeAlgorithms (algo);
			break;

		case "platform":
			PlayerStats.ChangePlatform (plat);
			break;

		case "NapTimewifSal":
			PlayerStats.ChangeMotivation (mot);
			break;

		case "project":
			PlayerStats.AddToProject (proj);
			break;

		case "CodeReview":
			PlayerStats.CodeReview (plat);
			break;
		case "HackerRank":
			PlayerStats.HackerRank(algo);
			break;
		case "ParseStone":
			PlayerStats.ParseStone(mot);
			break;
		default:
			break;
		}
		PlayerStats.ChangeTime (timeUsed);

	}

	void OnDestroy(){
	PlayerEvents.shesaidYes -= SwitchCase;	
	}



}
