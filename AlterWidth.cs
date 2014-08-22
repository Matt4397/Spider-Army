using UnityEngine;
using System.Collections;

public class AlterWidth : MonoBehaviour {

	[HideInInspector]
	public float width;

	// Use this for initialization
	void Start () {
		width = transform.localScale.x;
	}
	
	// Update is called once per frame
	void Update () {
		transform.localScale = new Vector3(width,
		                                   transform.localScale.y,
		                                   transform.localScale.z); 
	}
}
