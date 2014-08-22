using UnityEngine;
using System.Collections;

public class BackandForth : MonoBehaviour {


	public float speed = 10;
	public float borderleft;
	public float borderright;

	// Use this for initialization
	void Start () {
			rigidbody2D.velocity = new Vector2 (speed, 0);
			borderleft = transform.position.x + borderleft;
			borderright = transform.position.x + borderright;
	}

	// Update is called once per frame
	void Update () {
		if (transform.position.x > borderright) { 
			rigidbody2D.velocity = new Vector2 (-speed, 0);
		}	
		if (transform.position.x < borderleft) { 
			rigidbody2D.velocity = new Vector2 (speed, 0);
		
		}
	}
}
