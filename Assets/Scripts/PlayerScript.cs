﻿using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	private CharacterController charController;
	private static int playerCount = 0;
	private int playerNr;
	public float walkSpeed = 100f;
	public float turnSpeed = 200f;
	public GameObject projectile;
	public bool autoFire = false;

	// Use this for initialization
	void Start () {
		charController = this.GetComponent<CharacterController> ();
		playerCount++;
		playerNr = playerCount;
		Debug.Log ("I am player " + playerNr);
	}

	// Update is called once per frame
	void Update () {
		// movement
		float mh = Input.GetAxis("Horizontal" + playerNr);
		float mv = Input.GetAxis("Vertical" + playerNr);
		float rx = Input.GetAxis ("Mouse X" + playerNr);

		Vector3 directionv = transform.forward * mv;
		Vector3 directionh = transform.right * mh;
		Vector3 direction = (directionv + directionh) * Time.deltaTime * walkSpeed;
		charController.Move(direction);

		Vector3 rotation = new Vector3 (0, rx, 0) * Time.deltaTime * turnSpeed;
		charController.transform.Rotate (rotation);

		if (Input.GetButtonDown("Fire1" + playerNr)|| autoFire) {
			Vector3 bulletPos = transform.position + transform.forward;
			Debug.Log ("Forward " + transform.forward);
			Instantiate(projectile, bulletPos, transform.rotation);
		}

	}

	public int PlayerNr {
		get {
			return playerNr;
		}
	}
}
