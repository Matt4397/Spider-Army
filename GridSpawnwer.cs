using UnityEngine;
using System.Collections;

public class GridSpawnwer : MonoBehaviour {

	public GameObject gridObject;
	public int  IStart0;
	public int  IWidth;
	public int  IEnd1;
	public int  JStart0;
	public int  JHigth;
	public int  JEnd1;
	public int  BJStart1;
	public int  BJHight;
	public int  BIStart1;
	public int  BIWidth;
	public MethodButton _CreateGrid;


	// Use this for initialization
	void Start () {
		Debug.Log ("start");
		CreateGrid ();
	}

	public void CreateGrid(){
		Debug.Log ("create");
		for (float i = IStart0; i < IWidth; i=i+ IEnd1) {
			for ( float j = JStart0; j < JHigth; j += JEnd1){
				if (j < BJStart1 || j >=BJHight || i < BIStart1 || i >= BIWidth) {
					GameObject spawned = stTools.Spawn (gridObject);
					spawned.transform.position = new Vector2(transform.position.x + i,
					                                    	 transform.position.y + j);
				}
		}
	}
}
	
	// Update is called once per frame
	void Update () {

	//if (transform.position.x)
	
	}
}
