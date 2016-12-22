using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEvents : MonoBehaviour {

	public delegate void  PlayerEventsDelegate(string tag, int timeUsed);
	public static event PlayerEventsDelegate PlayerEvent;
	public static event PlayerEventsDelegate shesaidYes;

	public static void EventsHappen(string tag, int timeUsed)
	{

		if(PlayerEvent != null)
		{
			PlayerEvent(tag, timeUsed);
		}
	}
	public static void doSomeStuff(string tag, int timeUsed)
	{
		if(shesaidYes != null)
		{
			shesaidYes(tag, timeUsed);
		}
	}



}
