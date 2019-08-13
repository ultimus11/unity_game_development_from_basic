using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour {
	public float speed = 2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

		transform.Translate (speed*Time.deltaTime*Input.GetAxis ("Horizontal"), 0f, speed*Time.deltaTime*Input.GetAxis("Vertical"));
	}
}
