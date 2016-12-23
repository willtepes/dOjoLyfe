using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showScore : MonoBehaviour {
	Text dialog;
	string job;

	// Use this for initialization
	void Start () {
		dialog = this.gameObject.GetComponentsInChildren<Text>()[0];
		float morestuff = (float)PlayerStats.finalScore;

		int percent = (int)Mathf.Round(morestuff / 30);
		possibleJobs (percent);
		dialog.text = $"Congratulations your score is {percent}% You can get a job at {job}";



	}
	

	public void PlayAgain(){
		Application.LoadLevel (0);
	}
	public void QuitGame(){
		Application.Quit ();
	}
	public void possibleJobs(int percent)
	{
		
		if (percent >= 90) {
			job = "Google";
		} else if (percent >= 85 && percent < 90) {
			job = "Microsoft";
		} else if (percent >= 80 && percent < 85) {
			job = "Facebook";
		} else if (percent >= 75 && percent < 80) {
			job = "Coding Dojo";
		} else if (percent >= 70 && percent < 75) {
			job = "AirBnB";
		} else if (percent >= 65 && percent < 70) {
			job = "Amazon";
		} else {
			job = "McDonalds";
		}
	}
}
