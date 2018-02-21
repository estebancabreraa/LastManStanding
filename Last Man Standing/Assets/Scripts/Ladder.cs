using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour {
	public float speed =2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnTriggerStay2D(Collider2D collision)
	{
		if (collision.name == "Soldier" && Input.GetKey (KeyCode.UpArrow) && Alien.onLadder == true) {
			collision.GetComponent <Animator> ().SetBool ("isClimbing", true);
			collision.GetComponent <Rigidbody2D>().velocity = new Vector2 (0, speed);
		}
		else if (collision.name == "Soldier" && Input.GetKey (KeyCode.DownArrow) && Alien.onLadder == true) {
			collision.GetComponent <Rigidbody2D>().velocity = new Vector2 (0, -speed);
			collision.GetComponent <Animator> ().SetBool ("isClimbing", false);
		}
		else if (Alien.onLadder == false)
		{
			collision.GetComponent <Animator> ().SetBool ("isClimbing", false);
		}
			
			
	}
}
