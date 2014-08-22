using UnityEngine;
using System.Collections;

public class GridSpawnwer : MonoBehaviour {

	public GameObject gridObject;

	// Use this for initialization
	void Start () {

		for (float i = 0; i < 4; i=i+1) {
			for ( float j = 0; j < 5; j += 1){
			GameObject spawned = stTools.Spawn (gridObject);
			spawned.transform.position = new Vector2(transform.position.x + i,
			                                    	 transform.position.y + j);
		}
	}
}
	
	// Update is called once per frame
	void Update () {
	
	}
}
