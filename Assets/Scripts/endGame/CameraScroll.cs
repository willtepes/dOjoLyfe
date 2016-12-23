using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScroll : MonoBehaviour {

	public GameObject camera;
	public int scrollspeed;
	GameObject canvas;
	void Awake(){
		canvas = GameObject.Find ("EndScreen");
		canvas.SetActive (false);
			
	}
	// Update is called once per frame
	void Update () {
		
		camera.transform.Translate (Vector2.down * Time.deltaTime * scrollspeed);
		StartCoroutine (ShowButtons ());
	}
	IEnumerator ShowButtons()
	{
		yield return new WaitForSeconds (72);
		canvas.SetActive (true);

	}
}
