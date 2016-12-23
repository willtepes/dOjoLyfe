using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformEvent {

    public delegate void PlatformHandler();

    public static event PlatformHandler dotheUpdateUI;

    public static void UpdateUI()
    {
        if(dotheUpdateUI != null)
        {
            dotheUpdateUI();
        }
    }
    
}
