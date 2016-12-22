using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	public static bool canmove;

	Rigidbody2D rBody;
	Animator anim;

	// Use this for initialization
	void Awake () {
		canmove = true;
		rBody = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (canmove == true) {

			Vector2 movement_vector = new Vector2 (Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical"));

			if (movement_vector != Vector2.zero) {
				anim.SetBool ("iswalking", true);
				anim.SetFloat ("input_x", movement_vector.x);
				anim.SetFloat ("input_y", movement_vector.y);
			} else {
				anim.SetBool ("iswalking", false);
			}
			rBody.MovePosition (rBody.position + (movement_vector * Time.deltaTime * 3));;
		} 
		else
		{
			anim.SetBool ("iswalking", false);
		}
	}
		
}
