using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter (Collider collider)
	{
		Debug.Log ("OnTriggerEnter");
		Destroy (gameObject);
		Destroy (collider);
		MoveScript ms = collider.GetComponent<MoveScript> ();
		if (ms == null) { // not a player

		}
	}
}
