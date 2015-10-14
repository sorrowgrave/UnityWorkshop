using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {
	private CharacterController charController;
	private static int playercount = 0;
	private int playernr;
	public float walkSpeed = 100f;
	public float turnSpeed = 200f;
	public GameObject projectile;

	// Use this for initialization
	void Start () {
		charController = this.GetComponent<CharacterController> ();
		playercount++;
		playernr = playercount;
		Debug.Log ("I am player " + playernr);
	}

	// Update is called once per frame
	void Update () {
		float mh = Input.GetAxis("Horizontal" + playernr);
		float mv = Input.GetAxis("Vertical" + playernr);
		float rx = Input.GetAxis("Mouse X");

		Vector3 directionv = transform.forward * mv;
		Vector3 directionh = transform.right * mh;
		Vector3 direction = (directionv + directionh) * Time.deltaTime * walkSpeed;
		Vector3 rotation = new Vector3 (0, rx, 0)* Time.deltaTime * turnSpeed;
	
		charController.Move(direction);
		charController.transform.Rotate(rotation);

		if (Input.GetButtonDown("Fire1")) {
			Vector3 bulletPos = transform.position + transform.forward * Time.deltaTime * walkSpeed;
			Instantiate(projectile, bulletPos, transform.rotation);
		}

	}
}
