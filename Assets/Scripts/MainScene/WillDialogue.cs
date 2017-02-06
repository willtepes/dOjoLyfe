using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

// Special dialogue manager for Will NPC allowing charecter to die after third dialogue.
public class WillDialogue : MonoBehaviour {

	public string dialogue1;
	public string dialogue2;

	public bool canInteract = false;

	public string dialogue3;
	private string dialogue;
	public  DialogueManager dMan;
	Animator anim;
	public AudioClip DeathSound;
	private AudioSource source;
	public float volLowRange = .5f;
	public float volHighRange = 1.0f;
	public Renderer rend;

	// Use this for initialization
	void Start () {
		var manObj = GameObject.FindGameObjectWithTag("DialogueManager");
		dMan = manObj.GetComponent<DialogueManager>();
		anim = GetComponent<Animator>();
		source = GetComponent<AudioSource>();
		rend = GetComponent<Renderer>();
	}

	// Update is called once per frame - shows dialogue box on screen if Player close enough to NPC and clicks submit
	void Update () {
		if(canInteract == true && Input.GetButtonUp("Submit")){
			showDialouge();
		}
	}

	// canInteract set to true when player enters collider
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Player")
		{
			canInteract = true;
		}
	}

	// caninteract set to false when player leaves collider
	void OnTriggerExit2D(Collider2D other)
	{
		if(other.tag == "Player")
		{
			canInteract = false;
		}
	}

	// Sets dialogue on dialogue box based on game time left.  Runs Death coroutine after 3rd dialogue option shown.
	void showDialouge(){
		if(PlayerStats.TimeLeft > 66)
		{
			dialogue = dialogue1;
		}else if(PlayerStats.TimeLeft > 33){
			dialogue = dialogue2;
		}else{
			dialogue = dialogue3;
			dMan.ShowBox(dialogue);
			canInteract = false;
			StartCoroutine(Death());
		}
		dMan.ShowBox(dialogue);
		canInteract = false;
	}

	// Runs death animation and plays Deathsound.  Once animation completes Will gameobject is set to inactive.
	IEnumerator Death()
	{
		yield return new WaitForSeconds(1f);
		anim.SetTrigger("DeathTrigger");
		

		source.PlayOneShot(DeathSound, 1F);

		yield return new WaitForSeconds(2.5f);
		gameObject.SetActive(false);
	}
}