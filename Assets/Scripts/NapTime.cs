using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NapTime : MonoBehaviour {

    public int MotivationToAdd;

    public int Time;

    void Start()
    {

    }

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 20), "Banana");
    }

    void OnTriggerEnter2D()
    {
        GUI.Label(new Rect(10, 10, 200, 20), "Banana");
        PlayerStats.ChangeMotivation(MotivationToAdd);
        PlayerStats.ChangeTime(Time);
    }
}
