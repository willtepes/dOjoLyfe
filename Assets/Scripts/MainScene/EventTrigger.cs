using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTrigger : MonoBehaviour {
	public int time; 


	 void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag == "Player")
		{
			PlayerEvents.EventsHappen(gameObject.tag, time);
		}
		
	}
}
