using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NapTime : MonoBehaviour {

    public int MotivationToAdd;

    public int Time;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D()
    {
        PlayerStats.ChangeMotivation(MotivationToAdd);
        PlayerStats.ChangeTime(Time);
    }
}
