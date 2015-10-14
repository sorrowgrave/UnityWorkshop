using UnityEngine;
using System.Collections;

public class PowerUpScript : MonoBehaviour {
	public float rotationSpeed = 20f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 rotation = new Vector3 (1,2,3) * Time.deltaTime * rotationSpeed;
		transform.Rotate (rotation);
	}

	public void OnTriggerEnter (Collider collider)
	{
		Debug.Log ("Powerup taken");
		Destroy (gameObject);
		PlayerScript ms = collider.GetComponent<PlayerScript> ();
		if (ms != null) { // not a player
			ms.autoFire = !ms.autoFire;
		}
	}
}
