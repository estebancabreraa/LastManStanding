using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour {
	public GameObject personaje;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			transform.position = new Vector3 (personaje.transform.position.x, transform.position.y, transform.position.z); 
	}
}
