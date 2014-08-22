using UnityEngine;
using System.Collections;

public class Alter_Interval : MonoBehaviour {

	[HideInInspector]
	public float interval;

	// Use this for initialization
	void Start () {
		interval = GetComponent<AutoSpawner> ().timing.interval;
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<AutoSpawner>().timing.interval = interval;
	}
}
