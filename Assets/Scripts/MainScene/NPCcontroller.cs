using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script for controlling NPC movement
public class NPCcontroller : MonoBehaviour {

	public float moveSpeed;
	private Rigidbody2D myRigidbody;
	private bool moving;
	public float timeBetweenMove;
	private float timeBetweenMoveCounter;
	public float timeToMove;
	private float timeToMoveCounter;
	private Vector2 moveDirection;
	private Animator anim;

	// Use this for initialization - gets components from NPC game object
	void Start () {
		myRigidbody = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();

		timeBetweenMoveCounter = timeBetweenMove;
		timeToMoveCounter = timeToMove;
	}
	
	// Update is called once per frame
	void Update () {
		// If NPC currently moving timeToMoveCOunter counts down and game object moves in moveDirection. MoveDirection x and y are passed to animator.
		// Once timeToMove counter counts down moving stops and timeBetweenMoveCounter is set. Animator iswalking bool is set to false.
		if(moving)
		{
			timeToMoveCounter -= Time.deltaTime;
			myRigidbody.velocity = moveDirection;
			anim.SetFloat("input_x", moveDirection.x);
			anim.SetFloat("input_y", moveDirection.y);
			if(timeToMoveCounter <0f)
			{
				moving = false;
				timeBetweenMoveCounter = timeBetweenMove;
				anim.SetBool("iswalking", false);
			}
		// if NPC is not moving timeBetweenMoveCounter counts down and velocity is set to zero. Once timeBetweenMoveCounter counts down moving bool is set to true
		// timeToMoveCounter is set and random vector is set to moveDirection.  Animator iswalking bool set to true.
		}else{
			timeBetweenMoveCounter -= Time.deltaTime;
			myRigidbody.velocity = Vector2.zero;
			if(timeBetweenMoveCounter < 0f)
			{
				moving = true;
				timeToMoveCounter = timeToMove;
				moveDirection = new Vector2(Random.Range(-1f,1f) * moveSpeed, Random.Range(-1f,1f) * moveSpeed);
				anim.SetBool("iswalking", true);
			}
		}
	}
}
