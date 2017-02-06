using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	public static bool canmove;

	Rigidbody2D rBody;
	Animator anim;

	// Use this for initialization - Gets rigitbody and animator from player game object and sets canmove bool to true.
	void Awake () {
		canmove = true;
		rBody = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame - While canmove is true gets current movement vector from user input.  If vector is not zero sets iswalking bool to true and passes
	// x and y inputs to animator.  If movement vector is zero sets iswalking bool to false.  Updates player position based on movement_vector. If canmove is set
	// to false animator iswalking bool also set to false.
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
