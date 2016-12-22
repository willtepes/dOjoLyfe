using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTrigger : MonoBehaviour {
	public int time; 


	 void OnTriggerEnter2D()
	{
		
		PlayerEvents.EventsHappen(gameObject.tag, time);
	}
}
