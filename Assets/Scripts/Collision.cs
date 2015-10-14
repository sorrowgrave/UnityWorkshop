﻿using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour {
	public int ownerNr;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter (Collider collider)
	{
		Debug.Log ("Bullet hit!");
		PlayerScript ms = collider.GetComponent<PlayerScript> ();
		if (ms != null) { // not a player
			if(ms.PlayerNr != ownerNr){
				Destroy (collider.gameObject);
				Destroy (gameObject);
			}
		}

	}
}
