using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectHype : MonoBehaviour {

    public int DoTheProject;

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
        PlayerStats.AddToProject(DoTheProject);
        PlayerStats.ChangeTime(Time);
    }
}
