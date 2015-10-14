using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour {
	public int ownerNr;
	public GameObject explosion;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerEnter (Collider collider)
	{
		Debug.Log ("Bullet hit!");
		PlayerScript player = collider.GetComponent<PlayerScript> ();
		if (player != null) { // not a player
			if(player.PlayerNr != ownerNr){
				GameObject collidingObj = collider.gameObject;
				Instantiate(explosion, collidingObj.transform.position, collidingObj.transform.rotation);
				player.respawn(this.gameObject);
				// Destroy (collidingObj);
				Destroy (gameObject);
			}
		}

	}
}
