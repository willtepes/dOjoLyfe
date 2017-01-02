using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

	// Use this for initialization
	void Start () {
		myRigidbody = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();

		timeBetweenMoveCounter = timeBetweenMove;
		timeToMoveCounter = timeToMove;
	}
	
	// Update is called once per frame
	void Update () {
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
