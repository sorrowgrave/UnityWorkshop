using UnityEngine;
using System.Collections;

public class MoveBullet : MonoBehaviour
{
	public float speed = 100f;

	// Use this for initialization
	void Start ()
	{
		//Debug.Log (transform.position +" " + transform.rotation);
	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector3 directionv = transform.forward * Time.deltaTime * speed;
		transform.position = transform.position + directionv;
	}
}
