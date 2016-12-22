using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoThePlatform : MonoBehaviour {

    public int PlatformIncrease;

    public int Time;

    void Start()
    {

    }

    void Update()
    {

    }

    void OnTriggerEnter2D()
    {
        PlayerStats.ChangePlatform(PlatformIncrease);
        PlayerStats.ChangeTime(Time);
    }
}
