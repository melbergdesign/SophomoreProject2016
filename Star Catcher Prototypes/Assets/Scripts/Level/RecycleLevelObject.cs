using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//needed for delegates
using System;

public class RecycleLevelObject : MonoBehaviour {

	private Vector3 newLocation;
	public List<Recycler> recyclableList;
	private int i = 0;

	//subscribe to the list's action
	void Start()
	{
		//creates a new list object in memory
		recyclableList = new List<Recycler>();
        //tells the script to treat this object (attached to script) to rules in RecycleAction and if it passes, add it to the list
		Recycler.RecycleAction += RecycleActionHandler;

		for(int _p = 0; _p<2; _p++){
			PlaceNewLand();
		}
	}

	private void RecycleActionHandler(Recycler _r)
	{
		//adds each cube to list of items that can be recycled
		recyclableList.Add(_r);
       
	}

	void PlaceNewLand(){
		
		//i = UnityEngine.Random.Range(0, recyclableList.Count - 1);
		print (i);
		newLocation.x = StaticVars.nextSectionPosition;
		recyclableList[i].transform.position = newLocation;
		StaticVars.nextSectionPosition += StaticVars.distance;

		//removes just selected cube from list
		if (recyclableList.Count > 0)
		{
			//removes recyclableList entry at i position
			recyclableList.RemoveAt(i);
		}
	}

	void OnTriggerEnter()
	{
		PlaceNewLand ();

	}
}