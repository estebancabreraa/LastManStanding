using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRobot : MonoBehaviour {
	public float elapsedTime =0f;
	public float shootTime =3f;
	public float soundPlay = 0f; // para que el sonido suene antes de disparar, ya que tiene retraso
	public GameObject laser;
	AudioSource audio;


	// Use this for initialization
	void Start () {
		
		audio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (GameController.instance.gameOver == false)
		{
			if (elapsedTime < shootTime) 
			{
				elapsedTime += Time.deltaTime;
				soundPlay += Time.deltaTime;
				if(soundPlay > (shootTime* 0.60f))
				{
					audio.Play();
					soundPlay =0f;
				}
			} 
			else 
			{
				Instantiate (laser, new Vector3 (19.99f, 1.098361f, 0f), Quaternion.identity);
				elapsedTime = 0f;	
			}
		}
		
	}
}
